using NAC_Aircraft_Checklist.Models.Entry.B1900;
using NAC_Aircraft_Checklist.Models.Proof.B1900;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.ProofRead.B1900
{
    [Table(Names.Tables.B1900.ProofReads.OperationDocuments, Schema = Names.Tables.B1900.ProofReads.Schema)]
    public class B1900ProofReadOperationDocuments : ProofReadEntryBase
    {
        public bool DateIfApplicableFlagged { get; set; }
        public bool RevStatusFlagged { get; set; }
        public bool RevTextFlagged { get; set; }
        public DateTime? DateIfApplicable { get; set; }
        public string? RevStatus { get; set; }
        public static B1900ProofReadOperationDocuments Compare(B1900ProofOperationDocuments proof, B1900OperationDocuments entry)
        {
            B1900ProofReadOperationDocuments item = new B1900ProofReadOperationDocuments();
            item.ProofId = proof.ProofID;
            item.EntryId = entry.EntryId;
            item.DateIfApplicable = entry.DateIfApplicable;
            item.RevisionText = entry.RevisionText;
            item.RevStatus = entry.RevStatus;
            item.Comments = entry.Comments;
            item.DescriptionId = proof.DescriptionId;
            item.RevStatusFlagged = entry.RevStatus == null || proof.RevStatus == null ? false : entry.RevStatus.Contains(proof.RevStatus);
            item.DateIfApplicableFlagged = entry.DateIfApplicable == null || proof.DateIfApplicable == null ? false : DateTime.Equals(proof.DateIfApplicable.Value.Date, entry.DateIfApplicable.Value.Date);
            item.RevTextFlagged = entry.RevisionText == null || proof.RevisionText == null ? false : entry.RevisionText.Contains(proof.RevisionText);
            return item;
        }
    }
}
