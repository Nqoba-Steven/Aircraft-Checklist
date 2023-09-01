using NAC_Aircraft_Checklist.Models.Documents;
using NAC_Aircraft_Checklist.Models.Entry.B1900;
using NAC_Aircraft_Checklist.Models.Entry.Learjet;

namespace NAC_Aircraft_Checklist.Data.Services.Documents
{
    public interface ILearjetDocumentService
    {
        public Task Add(LearjetDocument learjetDocument);
        public Task<LearjetDocument> GetByID(int id);
        public LearjetEntry[][] GroupEntriesByDate();
        public  Task<IEnumerable<LearjetEntry>> GetEntries();
        public LearjetEntry CreateEntry(LearjetEntry e);

    }
}
