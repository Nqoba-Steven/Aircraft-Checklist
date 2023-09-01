using System.ComponentModel.DataAnnotations.Schema;
using NAC_Aircraft_Checklist.Util;
using NAC_Aircraft_Checklist.Models.Entry;
namespace NAC_Aircraft_Checklist.Models.Entry.B1900
{
    [Table(Names.Tables.B1900.Entries.Equipment, Schema = Names.Tables.B1900.Entries.Schema)]
    public class B1900Equipment : EntryBase
    {
        public DateTime? DateIfApplicable { get; set; }
        public string? RevStatusQTY { get; set; }

        public override string ToString()
        {
            return $" DateIfApp :{DateIfApplicable}\t RevStatus: {RevStatusQTY}\t {base.ToString()}";
        }
    }
}
