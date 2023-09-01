using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NAC_Aircraft_Checklist.Util;

namespace NAC_Aircraft_Checklist.Models.Entry.Learjet
{
    [Table(Names.Tables.Learjet.Entries.AircraftFlipFile, Schema = Names.Tables.Learjet.Entries.Schema)]
    public class LearjetAircraftFlipFile : EntryBase
    {
        public DateTime? DateIfApplicable { get; set; }
        public string? RevStatusQTY { get; set; }
    }
}
