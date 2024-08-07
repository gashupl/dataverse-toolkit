using Microsoft.PowerPlatform.Dataverse.Client;
using Model = Pg.Dataverse.Model;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // Create a new task entity
            var task = new Model.Entities.Task();
            task.Subject = subject;

            Guid taskId = _serviceClient.Create(task);

            return taskId;
        }
    }
}
