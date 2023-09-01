using System.ComponentModel.DataAnnotations.Schema;
using NAC_Aircraft_Checklist.Util;
namespace NAC_Aircraft_Checklist.Models.Entry.Learjet
{
    [Table(Names.Tables.Learjet.Entries.Cockpit, Schema = Names.Tables.Learjet.Entries.Schema)]
    public class LearjetCockpit: EntryBase
    {
        //public DateTime ExpiryDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? Status { get; set; }

    }
}
