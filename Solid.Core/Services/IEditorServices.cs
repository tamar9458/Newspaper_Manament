using ManagingANewspaper;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IEditorService
    {
       

        public IEnumerable<Editor> GetAll();


        public Editor GetById(int id);


        public Editor PostEditor(Editor value);


        public Editor PutEditor(int id, Editor value);

        public Editor DeleteEditor(int id);
    }
}
