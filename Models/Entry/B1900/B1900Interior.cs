using System.ComponentModel.DataAnnotations.Schema;
using NAC_Aircraft_Checklist.Util;
using NAC_Aircraft_Checklist.Models.Entry;
namespace NAC_Aircraft_Checklist.Models.Entry.B1900
{

    [Table(Names.Tables.B1900.Entries.Interior, Schema = Names.Tables.B1900.Entries.Schema)]
    public class B1900Interior : EntryBase
    {
        public string Status { get; set; }

        public override string  ToString() {
            return  $" Status {Status} {base.ToString()}";
        }
    }
}
