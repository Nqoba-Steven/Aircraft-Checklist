using NAC_Aircraft_Checklist.Models.Entry.B1900;
using NAC_Aircraft_Checklist.Models.Entry.Learjet;
using NAC_Aircraft_Checklist.Models.Proof.B1900;
using NAC_Aircraft_Checklist.Models.Proof.Learjet;
using NAC_Aircraft_Checklist.Models.ProofRead.B1900;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.ProofRead.Learjet
{
    [Table(Names.Tables.Learjet.ProofReads.Cockpit, Schema = Names.Tables.Learjet.ProofReads.Schema)]
    public class LearjetProofReadCockpit : ProofReadEntryBase
    {
        public bool ExpiryDateFlagged { get; set; }
        public bool StatusFlagged { get; set; }
        public bool RevTextFlagged { get; set; }
        public string? Status { get; set; }

        public DateTime? ExpiryDate { get; set; }
        public static LearjetProofReadCockpit Compare(LearjetProofCockpit proof, LearjetCockpit entry)
        {
            LearjetProofReadCockpit item = new LearjetProofReadCockpit();
            item.ProofId = proof.ProofID;
            item.EntryId = entry.EntryId;
            item.Status = entry.Status;
            item.ExpiryDate = entry.ExpiryDate;
            item.RevisionText = entry.RevisionText;
            item.Comments = entry.Comments;

            item.DescriptionId = proof.DescriptionId;
            item.StatusFlagged = proof.Status == null || entry.Status == null ? false : entry.Status.Contains(proof.Status);
            item.ExpiryDateFlagged = entry.ExpiryDate == null || proof.ExpiryDate == null ? false : DateTime.Equals(proof.ExpiryDate.Value.Date, entry.ExpiryDate.Value.Date);
            item.RevTextFlagged = entry.RevisionText == null || proof.RevisionText == null ? false : entry.RevisionText.Contains(proof.RevisionText);
            return item;
        }
    }
}
