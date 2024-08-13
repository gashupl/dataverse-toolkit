using Microsoft.PowerPlatform.Dataverse.Client;
using Model = Pg.Dataverse.Model;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk.Messages;

namespace Pg.Dataverse.Kafka.Data
{
    internal class TaskRepository
    {
        private readonly ServiceClient _serviceClient;

        public TaskRepository(string connectionString)
        {
            _serviceClient = new ServiceClient(connectionString);
        }

        public Guid Create(string subject)
        {
            var task = new Model.Entities.Task();
            task.Subject = subject;
            Guid taskId = _serviceClient.Create(task);
            return taskId;
        }

        public void CreateMultiple(List<string> subjects, int maxDegreeOfParallelism, int maxRequestsPerBatch)
        {
            var tasks = subjects.Select(s => new Model.Entities.Task { Subject = s }).ToList();

            Parallel.ForEach(tasks,
                  new ParallelOptions { MaxDegreeOfParallelism = 10 },
                  () => new
                  {
                      Service = _serviceClient.Clone(),
                      ExecuteMultipleRequest = new ExecuteMultipleRequest
                      {
                          Requests = new OrganizationRequestCollection(),
                          Settings = new ExecuteMultipleSettings
                          {
                              ContinueOnError = false,
                              ReturnResponses = true
                          }
                      }
                  },
                  (entity, loopState, index, threadLocalState) =>
                  {
                      threadLocalState.ExecuteMultipleRequest.Requests.Add(new CreateRequest { Target = entity });
                      if (threadLocalState.ExecuteMultipleRequest.Requests.Count == maxRequestsPerBatch)
                      {
                          var response = 
                            (ExecuteMultipleResponse)threadLocalState.Service.Execute(threadLocalState.ExecuteMultipleRequest);
                          HandleExecuteMultipleResponse(response); 
                          threadLocalState.ExecuteMultipleRequest.Requests.Clear();
                      }
                      return threadLocalState;
                  },
                  (threadLocalState) =>
                  {
                      if (threadLocalState.ExecuteMultipleRequest.Requests.Count > 0)
                      {
                          var response = 
                            (ExecuteMultipleResponse)threadLocalState.Service.Execute(threadLocalState.ExecuteMultipleRequest);
                          HandleExecuteMultipleResponse(response);
                      }
                      threadLocalState.Service.Dispose();
                  });
        }

        private void HandleExecuteMultipleResponse(ExecuteMultipleResponse response)
        {
            foreach (var responseItem in response.Responses)
            {
                if (responseItem.Fault != null)
                {
                    // Handle faulted response
                    Console.WriteLine($"Error: {responseItem.Fault.Message}");
                }
                else
                {
                    // Handle successful response
                    Console.WriteLine("Request succeeded.");
                }
            }
        }
    }
}
