using ManagingANewspaper;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IDesignerService
    {
      
        public IEnumerable<Designer> GetAll();


        public Designer GetById(int id);


        public Designer PostDesigner(Designer value);


        public Designer PutDesigner(int id, Designer value);


        public Designer DeleteDesigner(int id);
        
    }
}
