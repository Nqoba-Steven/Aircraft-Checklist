using NAC_Aircraft_Checklist.Models.Proof.B1900;
using NAC_Aircraft_Checklist.Models.Proof.Document;

namespace NAC_Aircraft_Checklist.Data.Services.Proof
{
    public interface IB1900ProofService
    {
        public B1900Proof Add(B1900Proof proof);
        public B1900Proof GetLatestProof();
        public B1900Proof GetLatestProof(int aircraftId);
        public B1900Proof GetById(int id);
        public Task<IEnumerable<B1900Proof>> GetAll();
        public B1900Proof[][] GroupByMonths();
        public B1900Proof GetProofByMonth(int aircraftId, DateTime month);
        public Task<B1900ProofDocument> GetProofDocument(B1900Proof proof);
        public Task<B1900ProofDocument> GetLatestProofDocument(int aircraftId);
        public Task AddProofDocument(B1900ProofDocument document);
    }
}
