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
             return _context.Designers;
        }

        public Designer Get(int id)
        {
            Designer designer = new Designer();
            return _context.Designers.Find(id);
         
        }

       
        public Designer Post( Designer value)
        {
            _context.Designers.Add(value);
            _context.SaveChanges();
            return _context.Designers.Find( value.Id);
        }

     
        public Designer Put(int id, Designer value)
        {
            Designer designer;
            designer = _context.Designers.Find(id);
            if (designer != null)
            {
                designer.Worker.Name = value.Worker.Name;
                designer.Worker.Phone = value.Worker.Phone;
                designer.Worker.Adress = value.Worker.Adress;
                designer.IsDesigningAi = value.IsDesigningAi;
                designer.Worker.Priority = value.Worker.Priority;
                _context.SaveChanges();
            }
            return designer;
            
        }

       
        public Designer Delete(int id)
        {
            Designer designer;
            designer = _context.Designers.Find(id);
            if (designer != null)
            {
                _context.Designers.Remove(designer);
                _context.SaveChanges();
            }
            return designer;
        }
    }
}
