using System.ComponentModel.DataAnnotations.Schema;
using NAC_Aircraft_Checklist.Models.Entry;
using NAC_Aircraft_Checklist.Util;
namespace NAC_Aircraft_Checklist.Models.Entry.B1900
{
    [Table(Names.Tables.B1900.Entries.AircraftFlipFile, Schema = Names.Tables.B1900.Entries.Schema)]
    public class B1900AircraftFlipFile : EntryBase
    {
        public DateTime? DateIfApplicable { get; set; }
        public string? RevStatusQTY { get; set; }
        public override string ToString()
        {
            return $" DateIfApp :{DateIfApplicable}\t RevStatus: {RevStatusQTY}\t {base.ToString()}";
        }
    }
}
