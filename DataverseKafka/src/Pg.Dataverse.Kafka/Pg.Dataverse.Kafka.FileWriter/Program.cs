using Pg.Dataverse.Kafka.Data;

var fileRepo = new SubjectFileRepository(".\\kafka-event-log.txt"); 

for(int i = 0; i < 10; i++)
{
    fileRepo.InsertSubject($"Hello from Kafka {i}");
}

