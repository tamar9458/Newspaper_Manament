using ManagingANewspaper;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class DesignerRepository: IDesignerRepository
    {
        private readonly DataContext _context;
        public DesignerRepository( DataContext dd)
        {
            _context = dd;  
        }

        public IEnumerable<Designer> Get()
        {
             return _context._Designers;
        }

        public Designer Get(int id)
        {
            Designer designer = new Designer();
            return _context._Designers.Find(i => i.Id == id);
         
        }

       
        public Designer Post( Designer value)
        {
            _context._Designers.Add(value);
            return _context._Designers.Find(i => i.Id == value.Id);
        }

     
        public Designer Put(int id, Designer value)
        {
            Designer designer;
            designer = _context._Designers.Find(i => i.Id == id);
            if (designer != null)
            {
                designer.Name = value.Name;
                designer.Phone = value.Phone;
                designer.Adress = value.Adress;
                designer.IsDesigningAi = value.IsDesigningAi;
                designer.Priority = value.Priority;
            }
            return designer;
            
        }

       
        public Designer Delete(int id)
        {
            Designer designer;
            designer = _context._Designers.Find(i => i.Id == id);
            if (designer != null)
            {
                _context._Designers.Remove(designer);
            }
            return designer;
        }
    }
}
