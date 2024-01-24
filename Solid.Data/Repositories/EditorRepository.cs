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
            return _context.Editors;
        }

        public Editor Get(int id)
        {
            Editor editor = new Editor();
            return _context.Editors.Find(id);
          
        }


        public Editor Post(Editor value)
        {
            _context.Editors.Add(value);
            _context.SaveChanges();
            return _context.Editors.Find(value.Id);
        }


        public Editor Put(int id, Editor value)
        {
            Editor editor;
            editor = _context.Editors.Find(id);
            if (editor != null)
            {
                editor.Worker.Name = value.Worker.Name;
                editor.Worker.Phone = value.Worker.Phone;
                editor.Worker.Adress = value.Worker.Adress;
                editor.TEditor = value.TEditor;
                editor.Worker.Priority = value.Worker.Priority;
                _context.SaveChanges();
            }
            return editor;

        }


        public Editor Delete(int id)
        {
            Editor editor;
            editor = _context.Editors.Find(id);
            if (editor != null)
            {
                _context.Editors.Remove(editor);
                _context.SaveChanges() ;
            }
            return editor;
        }
    }
}
