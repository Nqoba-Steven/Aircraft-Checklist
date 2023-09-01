using NAC_Aircraft_Checklist.Models.Entry;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.Proof.Learjet
{
    [Table(Names.Tables.Learjet.Proofs.Cabin, Schema = Names.Tables.Learjet.Proofs.Schema)]
    public class LearjetProofCabin : EntryBase
    {
        public int ProofID { get; set; }
        public DateTime? ExpiryDate { get; set; }
        //public DateTime ExpiryDate { get; set; }
        public string? QtyStatus { get; set; }
    }
}
