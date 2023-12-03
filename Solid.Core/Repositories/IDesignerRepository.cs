using ManagingANewspaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solid.Core.Repositories
{
    public interface IDesignerRepository
    {
       
        public IEnumerable<Designer> Get();

        public Designer Get(int id);

        public Designer Post(Designer value);

        public Designer Put(int id, Designer value);

        public Designer Delete(int id);
    }
}
