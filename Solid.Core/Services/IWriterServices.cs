using ManagingANewspaper;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IWriterService
    {
       

        public IEnumerable<Writer> GetAll();


        public Writer GetById(int id);


        public Writer PostWriter(Writer value);


        public Writer PutWriter(int id, Writer value);
        
        public Writer DeleteWriter(int id);
        

    }
}
