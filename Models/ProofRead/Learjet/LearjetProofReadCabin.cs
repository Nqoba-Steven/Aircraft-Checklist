using NAC_Aircraft_Checklist.Models.Entry.Learjet;
using NAC_Aircraft_Checklist.Models.Proof.Learjet;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.ProofRead.Learjet
{
    [Table(Names.Tables.Learjet.ProofReads.Cabin, Schema = Names.Tables.Learjet.ProofReads.Schema)]
    public class LearjetProofReadCabin : ProofReadEntryBase
    {
        public bool ExpiryDateFlagged { get; set; }
        public bool StatusFlagged { get; set; }
        public bool RevTextFlagged { get; set; }
        public string? Status { get; set; }

        public DateTime? ExpiryDate { get; set; }
        public static LearjetProofReadCabin Compare(LearjetProofCabin proof, LearjetCabin entry)
        {
            LearjetProofReadCabin item = new LearjetProofReadCabin();
            item.ProofId = proof.ProofID;
            item.EntryId = entry.EntryId;
            item.DescriptionId = proof.DescriptionId;
            item.StatusFlagged = String.Equals(proof.QtyStatus, entry.QtyStatus, StringComparison.OrdinalIgnoreCase);
            item.ExpiryDateFlagged = String.Equals(proof.ExpiryDate, entry.ExpiryDate);
            return item;
        }
    }
}
