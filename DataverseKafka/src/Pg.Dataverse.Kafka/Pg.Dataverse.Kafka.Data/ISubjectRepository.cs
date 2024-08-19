using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg.Dataverse.Kafka.Data
{
    public interface ISubjectRepository
    {
        void InsertSubject(string subjectName);
    }
}
