using NAC_Aircraft_Checklist.Models.Entry;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.Proof.B1900
{
    [Table(Names.Tables.B1900.Proofs.AircraftFlipFile, Schema = Names.Tables.B1900.Proofs.Schema)]

    public class B1900ProofAircraftFlipFile : EntryBase
    {
        public int ProofID { get; set; }
        public DateTime? DateIfApplicable { get; set; }
        public string? RevStatusQTY { get; set; }
    }
}
