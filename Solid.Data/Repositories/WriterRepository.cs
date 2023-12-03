using ManagingANewspaper;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class WriterRepository: IWriterRepository
    {
        private readonly DataContext _context;
        public WriterRepository(DataContext dd)
        {
            _context = dd;
        }
        public IEnumerable<Writer> Get()
        {
            return _context._Writers;
        }

    
        public Writer Get(int id)
        {
           return _context._Writers.Find(i => i.Id == id);
        }

       
        public Writer Post( Writer value)
        {
            _context._Writers.Add(value);
            return _context._Writers.Find(i => i.Id ==value.Id);
        }

        public Writer Put(int id,  Writer value)
        {
            Writer writer;
            writer = _context._Writers.Find(i => i.Id == id);
            if (writer != null)
            {
                writer.Adress = value.Adress;
                writer.Name = value.Name;
                writer.Phone = value.Phone;
                writer.Salary = value.Salary;
                writer.TWriter = value.TWriter;
                writer.Priority = value.Priority;
                
            }
            return writer;
        }

    
        public Writer Delete(int id)
        {
            Writer writer;
            writer = _context._Writers.Find(i => i.Id == id);
            if (writer != null)
            {
                _context._Writers.Remove(writer);
            }
            return writer;

        }
    }
}
