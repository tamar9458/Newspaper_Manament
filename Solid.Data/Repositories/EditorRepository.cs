using ManagingANewspaper;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class EditorRepository: IEditorRepository
    {
        private readonly DataContext _context;
        public EditorRepository(DataContext dd)
        {
            _context = dd;
        }

        public IEnumerable<Editor> Get()
        {
            return _context._Editors;
        }

        public Editor Get(int id)
        {
            Editor editor = new Editor();
            return _context._Editors.Find(i => i.Id == id);
          
        }


        public Editor Post(Editor value)
        {
            _context._Editors.Add(value);
            return _context._Editors.Find(i => i.Id == value.Id);
        }


        public Editor Put(int id, Editor value)
        {
            Editor editor;
            editor = _context._Editors.Find(i => i.Id == id);
            if (editor != null)
            {
                editor.Name = value.Name;
                editor.Phone = value.Phone;
                editor.Adress = value.Adress;
                editor.TEditor = value.TEditor;
                editor.Priority = value.Priority;
              
            }
            return editor;

        }


        public Editor Delete(int id)
        {
            Editor editor;
            editor = _context._Editors.Find(i => i.Id == id);
            if (editor != null)
            {
                _context._Editors.Remove(editor);
            }
            return editor;
        }
    }
}
