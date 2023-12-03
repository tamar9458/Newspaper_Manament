using System.Formats.Asn1;
using System.Globalization;

namespace ManagingANewspaper
{
    public class DataContext
    {
        public readonly List<Designer> _Designers;
        public readonly List<Editor> _Editors;
        public readonly List<Writer> _Writers;
        public DataContext()
        {
            _Designers = new List<Designer>() {new Designer(),new Designer() };
            //using (var reader = new StreamReader("../Solid.Data/designers.csv")) 
            //using (var csv=new CsvReader(reader, CultureInfo.InvariantCulture))
            //{
            //    _Designers=csv.GetRecords<Designer>().ToList();
            //}
       
            _Editors = new List<Editor>() { new Editor(),new Editor()};
            //using (var reader = new StreamReader("../Solid.Data/editors.csv"))
            //using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            //{
            //    _Editors = csv.GetRecords<Editor>().ToList();
            //}
       
            _Writers = new List<Writer>() { new Writer(), new Writer() };
            //using (var reader =  new StreamReader("../Solid.Data/writers.csv"))
            //using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            //{
            //    _Writers = csv.GetRecords<Writer>().ToList();
            //}
        }
    }
}
