using System.Collections.Generic;

namespace NAC_Aircraft_Checklist.Util.Table
{
    public class Table<T>
    {
        public string Header { get; set; }
        public List<T> Fields { get; set; }
        public Table(string header, List<T> fields)
        {
            Header = header;    
            Fields = fields;
        }
        public Table(string header)
        {
            Header = header;
        }
        public Table(string header, IEnumerable<T> fields)
        {
            Header = header;
            Fields = new List<T>();
            foreach (var item in fields)
            {
                Fields.Add(item);
            }
        }
    }
}
