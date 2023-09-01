using NAC_Aircraft_Checklist.Models.Entry;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.Proof.Learjet
{
    [Table(Names.Tables.Learjet.Proofs.Manuals, Schema = Names.Tables.Learjet.Proofs.Schema)]
    public class LearjetProofManuals:EntryBase
    {
        public int ProofID { get; set; }
        public string? PublicationNumber { get; set; }
        public string? SetNumber { get; set; }

        public string? VolumeNumber { get; set; }

        public string? RevStatus { get; set; }

        public string? DocumentFormat { get; set; }
    }
}
