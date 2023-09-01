using NAC_Aircraft_Checklist.Models.Entry.B1900;
using NAC_Aircraft_Checklist.Models.Proof.B1900;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.ProofRead.B1900
{
    [Table(Names.Tables.B1900.ProofReads.Exterior, Schema = Names.Tables.B1900.ProofReads.Schema)]
    public class B1900ProofReadExterior : ProofReadEntryBase
    {
        public bool StatusFlagged { get; set; }
        public bool RevTextFlagged { get; set; }

        public static B1900ProofReadExterior Compare(B1900ProofExterior proof, B1900Exterior entry)
        {
            B1900ProofReadExterior item = new B1900ProofReadExterior();
            item.ProofId = proof.ProofID;
            item.EntryId = entry.EntryId;
            item.RevisionText = entry.RevisionText;
            item.Comments = entry.Comments;
            item.DescriptionId = proof.DescriptionId;
            item.StatusFlagged = entry.Status == null || proof.Status == null ? false : entry.Status.Contains(proof.Status);
            item.RevTextFlagged = entry.RevisionText == null || proof.RevisionText == null ? false : entry.RevisionText.Contains(proof.RevisionText);
            return item;
        }
    }
}
