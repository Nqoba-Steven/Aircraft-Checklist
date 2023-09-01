using Microsoft.EntityFrameworkCore;
using NAC_Aircraft_Checklist.Models;

namespace NAC_Aircraft_Checklist.Data.Services.MasterTables
{
    public class MasterListService : IMasterListService
    {
        private readonly AppDbContext _context;

        public MasterListService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<B1900MasterListPayload> GetB1900MasterLists(int revision)
        {
            try
            {
                B1900MasterListPayload masterListPayload = new B1900MasterListPayload();
                //Get the lis
                masterListPayload.AircraftFlipFile.Fields = await _context.B1900AircraftFlipFileMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.Cabin.Fields = await _context.B1900CabinMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.Cockpits.Fields = await _context.B1900CockpitMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.Equipment.Fields = await _context.B1900EquipmentMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.Exterior.Fields = await _context.B1900ExteriorMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.FlightFolder.Fields = await _context.B1900FlightRedFolderMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.Interior.Fields = await _context.B1900InteriorMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.Manuals.Fields = await _context.B1900ManualsMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.ManualsIPad.Fields = await _context.B1900ManualsIPadMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.OperationDocuments.Fields = await _context.B1900OpsDocsEquipmentMasterList.Where(item => item.Revision == revision).ToListAsync();

                return masterListPayload;
            }
            catch (Exception e)
            {

                System.Diagnostics.Debug.WriteLine(e);
                System.Diagnostics.Debug.WriteLine("Empty Master Payload");
                return new B1900MasterListPayload();
            }
        }
        public async Task<LearjetMasterListPayload> GetLearjetMasterLists(int revision)
        {
            try
            {
                LearjetMasterListPayload masterListPayload = new LearjetMasterListPayload();
                //Get the lis

                masterListPayload.AircraftFlipFile.Fields = await _context.LearjetAircraftFlipFileMasterList.Where(item=>item.Revision == revision).ToListAsync();
                masterListPayload.Cabin.Fields = await _context.LearjetCabinMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.Cockpits.Fields = await _context.LearjetCockpitMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.Equipment.Fields = await _context.LearjetEquipmentMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.Exterior.Fields = await _context.LearjetExteriorMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.FlightFolder.Fields = await _context.LearjetFlightFolderMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.Interior.Fields = await _context.LearjetInteriorMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.Manuals.Fields = await _context.LearjetManualsMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.ManualsEFB.Fields = await _context.LearjetManualsEFBMasterList.Where(item => item.Revision == revision).ToListAsync();
                masterListPayload.OperationDocuments.Fields = await _context.LearjetOperationDocumentsEquipmentMasterList.Where(item => item.Revision == revision).ToListAsync();
                return masterListPayload;
            }
            catch (Exception e)
            {

                System.Diagnostics.Debug.WriteLine(e);
                System.Diagnostics.Debug.WriteLine("Empty Master Payload");
                return new LearjetMasterListPayload();
            }
        }
    }
}
