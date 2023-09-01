using NAC_Aircraft_Checklist.Models.Entry.B1900;
using NAC_Aircraft_Checklist.Models.Proof.B1900;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.ProofRead.B1900
{
    [Table(Names.Tables.B1900.ProofReads.Equipment, Schema = Names.Tables.B1900.ProofReads.Schema)]
    public class B1900ProofReadEquipment : ProofReadEntryBase
    {
        public bool DateIfApplicableFlagged { get; set; }
        public bool RevStatusQTYFlagged { get; set; }
        public bool RevTextFlagged { get; set; }
        public DateTime? DateIfApplicable { get; set; }
        public string? RevStatusQTY { get; set; }

        public static B1900ProofReadEquipment Compare(B1900ProofEquipment proof, B1900Equipment entry)
        {
            B1900ProofReadEquipment item = new B1900ProofReadEquipment();
            item.ProofId = proof.ProofID;
            item.EntryId = entry.EntryId;
            item.DescriptionId = proof.DescriptionId;
            item.DateIfApplicable = entry.DateIfApplicable;
            item.RevisionText = entry.RevisionText;
            item.RevStatusQTY = entry.RevStatusQTY;
            item.Comments = entry.Comments;
            item.RevStatusQTYFlagged = entry.RevStatusQTY == null || proof.RevStatusQTY == null ? false : entry.RevStatusQTY.Contains(proof.RevStatusQTY);
            item.DateIfApplicableFlagged = entry.DateIfApplicable == null || proof.DateIfApplicable == null ? false : DateTime.Equals(proof.DateIfApplicable.Value.Date, entry.DateIfApplicable.Value.Date);
            item.RevTextFlagged = entry.RevisionText == null || proof.RevisionText == null ? false : entry.RevisionText.Contains(proof.RevisionText);
            return item;
        }
    }
}
