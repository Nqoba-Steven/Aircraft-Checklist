using NAC_Aircraft_Checklist.Models.Entry;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;

namespace NAC_Aircraft_Checklist.Models.Proof.B1900
{
    [Table(Names.Tables.B1900.Proofs.FlightFolder, Schema = Names.Tables.B1900.Proofs.Schema)]

    public class B1900ProofFlightFolder : EntryBase
    {
        public int ProofID { get; set; }
        public string? Status { get; set; }

        public DateTime? ExpiryDate { get; set; }
    }
}
