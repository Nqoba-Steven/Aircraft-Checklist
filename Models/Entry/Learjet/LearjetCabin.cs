using System.ComponentModel.DataAnnotations.Schema;
using NAC_Aircraft_Checklist.Util;
namespace NAC_Aircraft_Checklist.Models.Entry.Learjet
{
    [Table(Names.Tables.Learjet.Entries.Cabin, Schema = Names.Tables.Learjet.Entries.Schema)]
    public class LearjetCabin : EntryBase
    {
        public DateTime? ExpiryDate { get; set; }
        //public DateTime ExpiryDate { get; set; }
        public string? QtyStatus { get; set; }

    }
}
