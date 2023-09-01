using System.ComponentModel.DataAnnotations.Schema;
using NAC_Aircraft_Checklist.Models.Entry;
using NAC_Aircraft_Checklist.Util;
namespace NAC_Aircraft_Checklist.Models.Entry.B1900
{
    [Table(Names.Tables.B1900.Entries.AdditionalItems, Schema = Names.Tables.B1900.Entries.Schema)]
    public class B1900AdditionalItems: EntryBase
    {

        [Column("ItemName", Order = 3)]
        public string? ItemName { get;set; }
        public DateTime? DateIfApplicable { get; set; }

        public string? RevStatusQTY { get; set; }

        public override string ToString()
        {
            return $" Item :{ItemName}\t DateIfAppl: {DateIfApplicable}\t RevStatusQTY: {RevStatusQTY}\t {base.ToString()}";
        }
    }
}
