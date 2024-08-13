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
                              ReturnResponses = false
                          }
                      }
                  },
                  (entity, loopState, index, threadLocalState) =>
                  {
                      threadLocalState.ExecuteMultipleRequest.Requests.Add(new UpdateRequest { Target = entity });
                      if (threadLocalState.ExecuteMultipleRequest.Requests.Count == maxRequestsPerBatch)
                      {
                          threadLocalState.Service.Execute(threadLocalState.ExecuteMultipleRequest);
                          threadLocalState.ExecuteMultipleRequest.Requests.Clear();
                      }
                      return threadLocalState;
                  },
                  (threadLocalState) =>
                  {
                      if (threadLocalState.ExecuteMultipleRequest.Requests.Count > 0)
                      {
                          threadLocalState.Service.Execute(threadLocalState.ExecuteMultipleRequest);
                      }
                      threadLocalState.Service.Dispose();
                  });
        }
    }
}
