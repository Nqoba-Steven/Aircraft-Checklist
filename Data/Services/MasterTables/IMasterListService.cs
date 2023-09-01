using NAC_Aircraft_Checklist.Models;

namespace NAC_Aircraft_Checklist.Data.Services.MasterTables
{
    public interface IMasterListService
    {
        public Task<B1900MasterListPayload> GetB1900MasterLists(int revision);
        public Task<LearjetMasterListPayload> GetLearjetMasterLists(int revision);
    }
}
