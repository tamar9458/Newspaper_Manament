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
    public class DesignrService : IDesignerService
    {
        private readonly IDesignerRepository _designerRepository;
        public DesignrService(IDesignerRepository dd)
        {
            _designerRepository = dd;
        }

        public IEnumerable<Designer> GetAll() {
            return _designerRepository.Get();           
        }

        public Designer GetById(int id)
        { 
           return _designerRepository.Get(id);
        }

        public Designer PostDesigner(Designer value)
        {
            return _designerRepository.Post(value);
        }

        public Designer PutDesigner(int id, Designer value)
        {
            return _designerRepository.Put(id, value);
        }

        public Designer DeleteDesigner(int id) 
        {
            return _designerRepository.Delete(id);
        }
    }
}
