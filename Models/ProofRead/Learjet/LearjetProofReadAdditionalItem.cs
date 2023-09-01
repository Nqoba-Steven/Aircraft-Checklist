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
    [Table(Names.Tables.Learjet.ProofReads.AdditionalItems, Schema = Names.Tables.Learjet.ProofReads.Schema)]
    public class LearjetProofReadAdditionalItem : ProofReadEntryBase
    {
        public bool DateIfApplicableFlagged { get; set; }
        public bool RevStatusQTYFlagged { get; set; }
        public bool ItemNameFlagged { get; set; }
        public bool RevTextFlagged { get; set; }
        public string? ItemName { get; set; }
        public DateTime? DateIfApplicable { get; set; }

        public string? RevStatusQTY { get; set; }

        public static LearjetProofReadAdditionalItem Compare(LearjetProofAdditionalItem  proof, LearjetAdditionalItem entry)
        {
            LearjetProofReadAdditionalItem item = new LearjetProofReadAdditionalItem();
            item.ProofId = proof.ProofID;
            item.EntryId = entry.EntryId;
            item.DescriptionId = proof.DescriptionId;
            item.ItemName = entry.ItemName;
            item.DateIfApplicable = entry.DateIfApplicable;
            item.RevStatusQTY = entry.RevStatusQTY;
            item.RevisionText = entry.RevisionText;
            item.Comments = entry.Comments;

            item.ItemNameFlagged = entry.ItemName == null || proof.ItemName == null ? false : String.Equals(proof.ItemName, entry.ItemName, StringComparison.OrdinalIgnoreCase);
            item.RevStatusQTYFlagged = entry.RevStatusQTY == null || proof.RevStatusQTY == null ? false : String.Equals(proof.RevStatusQTY, entry.RevStatusQTY, StringComparison.OrdinalIgnoreCase);
            item.DateIfApplicableFlagged = entry.DateIfApplicable == null || proof.DateIfApplicable == null ? false : DateTime.Equals(proof.DateIfApplicable.Value.Date, entry.DateIfApplicable.Value.Date);
            item.RevTextFlagged = entry.RevisionText == null || proof.RevisionText == null ? false : String.Equals(proof.RevisionText, entry.RevisionText);
            return item;
        }
    }
}
