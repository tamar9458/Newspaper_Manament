using ManagingANewspaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IEditorRepository
    {
     
        public IEnumerable<Editor> Get();

        public Editor Get(int id);

        public Editor Post(Editor value);

        public Editor Put(int id, Editor value);

        public Editor Delete(int id);
    }
}
