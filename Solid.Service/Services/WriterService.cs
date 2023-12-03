using ManagingANewspaper;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solid.Service.Services
{
    public class WriterService: IWriterService
    {
        private readonly IWriterRepository _writerRepository;
        public WriterService(IWriterRepository dd)
        {
            _writerRepository = dd; 
        }

        public IEnumerable<Writer> GetAll()
        {
            return _writerRepository.Get();
        }

        public Writer GetById(int id)
        {
            return _writerRepository.Get(id);
        }

        public Writer PostWriter(Writer value)
        {
            return _writerRepository.Post(value);
        }

        public Writer PutWriter(int id, Writer value)
        {
            return _writerRepository.Put(id, value);
        }

        public Writer DeleteWriter(int id)
        {
            return _writerRepository.Delete(id);
        }

       
    }
}
