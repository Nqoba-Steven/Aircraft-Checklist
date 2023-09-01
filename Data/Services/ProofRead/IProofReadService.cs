using NAC_Aircraft_Checklist.Models;
using NAC_Aircraft_Checklist.Models.Documents;
using NAC_Aircraft_Checklist.Models.Proof.Document;
using NAC_Aircraft_Checklist.Models.ProofRead;
using NAC_Aircraft_Checklist.Models.ProofRead.B1900;
using NAC_Aircraft_Checklist.Models.ProofRead.Learjet;

namespace NAC_Aircraft_Checklist.Data.Services.ProofRead
{
    public interface IProofReadService
    {
        public Task<B1900ProofReadDocument> GetByIdB1900ProofReadDocument(int id);
        public Task<IEnumerable<B1900ProofReadEntry>> GetAllB1900ProofReadDocuments();
        public void AddB1900ProofReadDocument(B1900ProofReadDocument document);
        public void AddLearjetProofReadDocument(LearjetProofReadDocument document);
        public Task<LearjetProofReadDocument> GetByIdLearjetProofReadDocument(int id);
        public Task<IEnumerable<LearjetProofReadEntry>> GetAllLearjetProofReadDocuments();
        public B1900ProofReadDocument CreateProofRead1900( B1900ProofDocument proofDocument, B1900Document checklist);
        public LearjetProofReadDocument CreateProofReadLearjet(LearjetProofDocument proofDocument, LearjetDocument checklist);

        public B1900ProofReadDocument CreateProofRead1900(B1900MasterListPayload proofMaster, B1900MasterListPayload entryMaster, B1900ProofDocument proofDocument, B1900Document checklist);

        //Get
        //Add 
        //
    }
}
