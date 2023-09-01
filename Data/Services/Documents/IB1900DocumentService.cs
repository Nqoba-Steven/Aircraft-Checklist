using NAC_Aircraft_Checklist.Models.Documents;
using NAC_Aircraft_Checklist.Models.Entities;
using NAC_Aircraft_Checklist.Models.Entry.B1900;

namespace NAC_Aircraft_Checklist.Data.Services.Documents
{
    public interface IB1900DocumentService
    {
        public B1900Entry CreateEntry(B1900Entry entryB1900);
        public  Task<IEnumerable<B1900Entry>> GetEntries();
        public B1900Entry[][] GroupEntriesByDate();
        public Task Add(B1900Document document);
        public Task<B1900Document> GetByID(int id);
    }
}
