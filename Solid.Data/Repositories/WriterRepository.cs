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
            return _context.Writers;
        }

    
        public Writer Get(int id)
        {
           return _context.Writers.Find(id);
        }

       
        public Writer Post( Writer value)
        {
            _context.Writers.Add(value);
            _context.SaveChanges();
            return _context.Writers.Find(value.Id);
        }

        public Writer Put(int id,  Writer value)
        {
            Writer writer;
            writer = _context.Writers.Find(id);
            if (writer != null)
            {
                writer.Worker.Adress = value.Worker.Adress;
                writer.Worker.Name = value.Worker.Name;
                writer.Worker.Phone = value.Worker.Phone;
                writer.Worker.Salary = value.Worker.Salary;
                writer.TWriter = value.TWriter;
                writer.Worker.Priority = value.Worker.Priority;
                _context.SaveChanges();
            }
            return writer;
        }

    
        public Writer Delete(int id)
        {
            Writer writer;
            writer = _context.Writers.Find(id);
            if (writer != null)
            {
                _context.Writers.Remove(writer);
                _context.SaveChanges();
            }
            return writer;

        }
    }
}
