using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NAC_Aircraft_Checklist.Util;
namespace NAC_Aircraft_Checklist.Models.Entry.Learjet
{
    [Table(Names.Tables.Learjet.Entries.Enrty, Schema = Names.Tables.Learjet.Entries.Schema)]
    public class LearjetEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public int AircraftId { set; get; }
        public DateTime Date { set; get; }
        public int Revision { set; get; }
        public string CompletedBy { set; get; }
        public string BaseOfOperations { set; get; }
    }
}
