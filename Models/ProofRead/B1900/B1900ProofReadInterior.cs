using NAC_Aircraft_Checklist.Models.Entry.B1900;
using NAC_Aircraft_Checklist.Models.Proof.B1900;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.ProofRead.B1900
{
    [Table(Names.Tables.B1900.ProofReads.Interior, Schema = Names.Tables.B1900.ProofReads.Schema)]
    public class B1900ProofReadInterior : ProofReadEntryBase
    {
        public bool RevTextFlagged { get; set; }
        public bool StatusFlagged { get; set; }
        public static B1900ProofReadInterior Compare(B1900ProofInterior proof, B1900Interior entry) {
            B1900ProofReadInterior item = new B1900ProofReadInterior();
            item.ProofId = proof.ProofID;
            item.EntryId = entry.EntryId;
            item.DescriptionId = proof.DescriptionId;
            item.RevisionText = entry.RevisionText;
            item.Comments = entry.Comments;
            item.StatusFlagged = entry.Status == null || proof.Status == null ? false : String.Equals(proof.Status, entry.Status, StringComparison.OrdinalIgnoreCase);
            item.RevTextFlagged = entry.RevisionText == null || proof.RevisionText == null ? false : String.Equals(proof.RevisionText, entry.RevisionText);
            return item;
        }
    }
}
