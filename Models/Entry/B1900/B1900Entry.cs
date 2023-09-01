using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NAC_Aircraft_Checklist.Util;
using NAC_Aircraft_Checklist.Models.Entry;
namespace NAC_Aircraft_Checklist.Models.Entry.B1900
{
    [Table(Names.Tables.B1900.Entries.Enrty, Schema = Names.Tables.B1900.Entries.Schema)]
    public class B1900Entry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public int AircraftId { set; get; }
        public DateTime Date { set; get; }
        public int Revision { set; get; }
        public string CompletedBy { set; get; }
        public string BaseOfOperations { set; get; }

        public override string ToString()
        {
            return $"{base.ToString()}\tAircraftID:{AircraftId} \tDate:{Date} \tRevision:{Revision} \tCompletedBy:{CompletedBy} \tBaseOfOperations:{BaseOfOperations}";
        }
    }
}
