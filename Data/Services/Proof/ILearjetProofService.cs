using NAC_Aircraft_Checklist.Models.Proof.B1900;
using NAC_Aircraft_Checklist.Models.Proof.Document;
using NAC_Aircraft_Checklist.Models.Proof.Learjet;

namespace NAC_Aircraft_Checklist.Data.Services.Proof
{
    public interface ILearjetProofService
    {
        public LearjetProof Add(LearjetProof proof);
        public LearjetProof GetLatestProof();
        public LearjetProof GetById(int id);
        public LearjetProof[][] GroupByMonths();
        public LearjetProof GetProofByMonth(int aircraftId, DateTime date);

        public Task<IEnumerable<LearjetProof>> GetAll();
        public Task<LearjetProofDocument> GetProofDocument(LearjetProof proof);
        public Task<LearjetProofDocument> GetLatestProofDocument();
        public Task AddProofDocument(LearjetProofDocument document);
    }
}
