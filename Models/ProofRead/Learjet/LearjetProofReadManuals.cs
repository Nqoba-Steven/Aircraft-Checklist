using NAC_Aircraft_Checklist.Models.Entry.Learjet;
using NAC_Aircraft_Checklist.Models.Proof.Learjet;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.ProofRead.Learjet
{
    [Table(Names.Tables.Learjet.ProofReads.Manuals, Schema = Names.Tables.Learjet.ProofReads.Schema)]
    public class LearjetProofReadManuals : ProofReadEntryBase
    {
        public bool PublicationNumberFlagged { get; set; }
        public bool VolumeNumberFlagged { get; set; }
        public bool SetNumberFlagged { get; set; }
        public bool RevStatusFlagged { get; set; }
        public bool RevTextFlagged { get; set; }
        public bool DocumentFormatFlagged { get; set; }

        public string? PublicationNumber { get; set; }
        public string? SetNumber { get; set; }

        public string? VolumeNumber { get; set; }

        public string? RevStatus { get; set; }

        public string? DocumentFormat { get; set; }

        public static LearjetProofReadManuals Compare(LearjetProofManuals proof, LearjetManuals entry)
        {
            LearjetProofReadManuals item = new LearjetProofReadManuals();
            item.ProofId = proof.ProofID;
            item.EntryId = entry.EntryId;
            item.DescriptionId = proof.DescriptionId;
            item.Comments = entry.Comments;
            item.PublicationNumber = entry.PublicationNumber;
            item.SetNumber = entry.SetNumber;
            item.VolumeNumber = entry.VolumeNumber;
            item.RevStatus = entry.RevStatus;
            item.RevisionText = entry.RevisionText;
            item.DocumentFormat = entry.DocumentFormat;
            item.PublicationNumberFlagged = entry.PublicationNumber == null || proof.PublicationNumber == null ? false : entry.PublicationNumber.Contains(proof.PublicationNumber);
            item.VolumeNumberFlagged = entry.VolumeNumber == null || proof.VolumeNumber == null ? false : entry.VolumeNumber.Contains(proof.VolumeNumber);
            item.SetNumberFlagged = entry.SetNumber == null || proof.SetNumber == null ? false : entry.SetNumber.Contains(proof.SetNumber);
            item.RevStatusFlagged = entry.RevStatus == null || proof.RevStatus == null ? false : entry.RevStatus.Contains(proof.RevStatus);
            item.DocumentFormatFlagged = entry.DocumentFormat == null || proof.DocumentFormat == null ? false : entry.DocumentFormat.Contains(proof.DocumentFormat);
            item.RevTextFlagged = entry.RevisionText == null || proof.RevisionText == null ? false : entry.RevisionText.Contains(proof.RevisionText);
            return item;
        }
    }
}
