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
    [Table(Names.Tables.Learjet.ProofReads.AircraftFlipFile, Schema = Names.Tables.Learjet.ProofReads.Schema)]
    public class LearjetProofReadAircraftFlipFile : ProofReadEntryBase
    {
        public bool DateIfApplicableFlagged { get; set; }
        public bool RevStatusQTYFlagged { get; set; }
        public bool RevTextFlagged { get; set; }
        public DateTime? DateIfApplicable { get; set; }
        public string? RevStatusQTY { get; set; }
        public static LearjetProofReadAircraftFlipFile Compare(LearjetProofAircraftFlipFile proof, LearjetAircraftFlipFile entry)
        {
            LearjetProofReadAircraftFlipFile item = new LearjetProofReadAircraftFlipFile();
            item.ProofId = proof.ProofID;
            item.EntryId = entry.EntryId;
            item.DateIfApplicable = entry.DateIfApplicable;
            item.RevStatusQTY = entry.RevStatusQTY;
            item.DescriptionId = proof.DescriptionId;
            item.RevisionText = entry.RevisionText;
            item.Comments = entry.Comments;

            item.RevStatusQTYFlagged = entry.RevStatusQTY == null || proof.RevStatusQTY == null ? false : entry.RevStatusQTY.Contains(proof.RevStatusQTY);
            item.DateIfApplicableFlagged = entry.DateIfApplicable == null || proof.DateIfApplicable == null ? false : DateTime.Equals(proof.DateIfApplicable.Value.Date, entry.DateIfApplicable.Value.Date);
            item.RevTextFlagged = entry.RevisionText == null || proof.RevisionText == null ? false : entry.RevisionText.Contains(proof.RevisionText);
            return item;
        }
    }
}
