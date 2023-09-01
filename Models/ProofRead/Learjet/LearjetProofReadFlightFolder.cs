using NAC_Aircraft_Checklist.Models.Entry.Learjet;
using NAC_Aircraft_Checklist.Models.Proof.Learjet;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.ProofRead.Learjet
{
    [Table(Names.Tables.Learjet.ProofReads.FlightFolder, Schema = Names.Tables.Learjet.ProofReads.Schema)]
    public class LearjetProofReadFlightFolder : ProofReadEntryBase
    {
        public bool ExpiryDateFlagged { get; set; }
        public bool RevStatusQTYFlagged { get; set; }
        public bool RevTextFlagged { get; set; }
        public string? Status { get; set; }

        public DateTime? ExpiryDate { get; set; }
        public static LearjetProofReadFlightFolder Compare(LearjetProofFlightFolder proof, LearjetFlightFolder entry)
        {
            LearjetProofReadFlightFolder item = new LearjetProofReadFlightFolder();
            item.ProofId = proof.ProofID;
            item.EntryId = entry.EntryId;
            item.ExpiryDate = entry.DateIfApplicable;
            item.Status = entry.RevStatus;
            item.RevisionText = entry.RevisionText;
            item.Comments = entry.Comments;

            item.DescriptionId = proof.DescriptionId;
            item.RevStatusQTYFlagged = entry.RevStatus == null || proof.RevStatus == null ? false : entry.RevStatus.Contains(proof.RevStatus);
            item.ExpiryDateFlagged = entry.DateIfApplicable == null || proof.DateIfApplicable == null ? false : DateTime.Equals(proof.DateIfApplicable.Value.Date, entry.DateIfApplicable.Value.Date);
            item.RevTextFlagged = entry.RevisionText == null || proof.RevisionText == null ? false : entry.RevisionText.Contains(proof.RevisionText);
            return item;
        }
    }
}
