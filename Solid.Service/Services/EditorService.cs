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
    public class EditorService: IEditorService
    {
        private readonly IEditorRepository _editorRepository;
        public EditorService(IEditorRepository dd)
        {
            _editorRepository = dd;
        }

        public IEnumerable<Editor> GetAll()
        {
           return _editorRepository.Get();            
        }

        public Editor GetById(int id)
        {
            return _editorRepository.Get(id);
        }

        public Editor PostEditor(Editor value)
        {
            return _editorRepository.Post(value);
        }

        public Editor PutEditor(int id, Editor value)
        {
            return _editorRepository.Put(id, value);
        }

        public Editor DeleteEditor(int id)
        {
             return _editorRepository.Delete(id);
        }

    }
}
