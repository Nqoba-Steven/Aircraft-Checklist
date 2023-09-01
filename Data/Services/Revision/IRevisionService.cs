using NAC_Aircraft_Checklist.Models.Entry.Revisions;

namespace NAC_Aircraft_Checklist.Data.Services.Revision
{
    public interface IRevisionService
    {
        public bool AddB1900Revision(B1900Revision revision);
        public bool AddLearjetRevision(LearjetRevision revision);
        public B1900Revision GetB1900RevisionById(int id);
        public B1900Revision GetB1900Revision(int number);
        public B1900Revision GetLatestB1900Revision();
        public LearjetRevision GetLearjetRevision(int id);
        public LearjetRevision GetLatestLearjetRevision();
        public Task<IEnumerable<B1900Revision>> GetAllB1900Revisions();
        public Task<IEnumerable<LearjetRevision>> GetAllLearjetRevisions();

    }
}
