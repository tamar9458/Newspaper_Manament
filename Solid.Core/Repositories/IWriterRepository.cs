using ManagingANewspaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solid.Core.Repositories
{
    public interface IWriterRepository
    {
      
        public IEnumerable<Writer> Get();

        public Writer Get(int id);

        public Writer Post(Writer value);

        public Writer Put(int id, Writer value);

        public Writer Delete(int id);
    }
}
