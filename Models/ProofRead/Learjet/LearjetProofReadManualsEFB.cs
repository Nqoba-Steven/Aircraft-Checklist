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
    [Table(Names.Tables.Learjet.ProofReads.ManualsEFB, Schema = Names.Tables.Learjet.ProofReads.Schema)]
    public class LearjetProofReadManualsEFB : ProofReadEntryBase
    {
        public bool PublicationNumberFlagged { get; set; }
        public bool VolumeNumberFlagged { get; set; }
        public bool SetNumberFOFlagged { get; set; }
        public bool SetNumberPICFlagged { get; set; }
        public bool RevStatusFlagged { get; set; }
        public bool RevTextFlagged { get; set; }
        public string? PublicationNumber { get; set; }
        public string? VolumeNumber { get; set; }
        public string? SetNumberFO { get; set; }
        public string? SetNumberPIC { get; set; }
        public string? RevStatus { get; set; }
        public static LearjetProofReadManualsEFB Compare(LearjetProofManualsEFB proof, LearjetManualsEFB entry)
        {
            LearjetProofReadManualsEFB item = new LearjetProofReadManualsEFB();
            item.ProofId = proof.ProofID;
            item.EntryId = entry.EntryId;
            item.DescriptionId = proof.DescriptionId;
            item.PublicationNumber = entry.PublicationNumber;
            item.VolumeNumber = entry.VolumeNumber;
            item.SetNumberFO = entry.SetNumberFO;
            item.SetNumberPIC = entry.SetNumberPIC;
            item.RevStatus = entry.RevStatus;
            item.Comments = entry.Comments;

            item.RevisionText = entry.RevisionText;
            item.PublicationNumberFlagged = entry.PublicationNumber == null || proof.PublicationNumber == null ? false : entry.PublicationNumber.Contains(proof.PublicationNumber);
            item.VolumeNumberFlagged = entry.VolumeNumber == null || proof.VolumeNumber == null ? false : entry.VolumeNumber.Contains(proof.VolumeNumber);
            item.SetNumberFOFlagged = entry.SetNumberFO == null || proof.SetNumberFO == null ? false : entry.SetNumberFO.Contains(proof.SetNumberFO);
            item.RevStatusFlagged = entry.RevStatus == null || proof.RevStatus == null ? false : entry.RevStatus.Contains(proof.RevStatus);
            item.SetNumberPICFlagged = entry.SetNumberPIC == null || proof.SetNumberPIC == null ? false : entry.SetNumberPIC.Contains(proof.SetNumberPIC);
            item.RevTextFlagged = entry.RevisionText == null || proof.RevisionText == null ? false : entry.RevisionText.Contains(proof.RevisionText);
            return item;
        }
    }
}
