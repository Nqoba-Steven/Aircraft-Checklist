using NAC_Aircraft_Checklist.Models.Tables;
using NAC_Aircraft_Checklist.Util;
using NAC_Aircraft_Checklist.Util.Table;

namespace NAC_Aircraft_Checklist.Models
{
    public class B1900MasterListPayload
    {
        public  Table<B1900AircraftFlipFileMaster> AircraftFlipFile { get; set; } = new Table<B1900AircraftFlipFileMaster>(Names.Tables.B1900.TableNames.AircraftFlipFile);
        public Table<B1900CabinMaster> Cabin { get; set; } = new Table<B1900CabinMaster>(Names.Tables.B1900.TableNames.Cabin);
        public Table<B1900CockpitMaster> Cockpits { get; set; } = new Table<B1900CockpitMaster>(Names.Tables.B1900.TableNames.Cockpit);
        public Table<B1900EquipmentMaster> Equipment { get; set; } = new Table<B1900EquipmentMaster>(Names.Tables.B1900.TableNames.Equipment); 
        public Table<B1900ExteriorMaster> Exterior { get; set; } = new Table<B1900ExteriorMaster>(Names.Tables.B1900.TableNames.Exterior);
        public Table<B1900FlightRedFolderMaster> FlightFolder { get; set; } = new Table<B1900FlightRedFolderMaster>(Names.Tables.B1900.TableNames.FlightFolder);
        public Table<B1900InteriorMaster> Interior { get; set; } = new Table<B1900InteriorMaster>(Names.Tables.B1900.TableNames.Interior);
        public Table<B1900ManualsMaster> Manuals { get; set; } = new Table<B1900ManualsMaster>(Names.Tables.B1900.TableNames.Manuals); 
        public Table<B1900ManualsIPadMaster> ManualsIPad { get; set; } = new Table<B1900ManualsIPadMaster>(Names.Tables.B1900.TableNames.ManualsIPad); 
        public Table<B1900OpsDocsEquipmentMaster> OperationDocuments { get; set; } = new Table<B1900OpsDocsEquipmentMaster>(Names.Tables.B1900.TableNames.OPSDocsEquipment);

    }
    public class LearjetMasterListPayload
    {
        public Table<LearjetAircraftFlipFileMaster> AircraftFlipFile { get; set; } = new Table<LearjetAircraftFlipFileMaster>(Names.Tables.Learjet.TableNames.AircraftFlipFile );
        public Table<LearjetCabinMaster> Cabin { get; set; } = new Table<LearjetCabinMaster>(Names.Tables.Learjet.TableNames.Cabin);
        public Table<LearjetCockpitMaster> Cockpits { get; set; } = new Table<LearjetCockpitMaster>(Names.Tables.Learjet.TableNames.Cockpit);
        public Table<LearjetEquipmentMaster> Equipment { get; set; } = new Table<LearjetEquipmentMaster>(Names.Tables.Learjet.TableNames.Equipment);
        public Table<LearjetExteriorMaster> Exterior { get; set; } = new Table<LearjetExteriorMaster>(Names.Tables.Learjet.TableNames.Exterior);
        public Table<LearjetFlightFolderMaster> FlightFolder { get; set; } = new Table<LearjetFlightFolderMaster>(Names.Tables.Learjet.TableNames.FlightFolder);
        public Table<LearjetInteriorMaster> Interior { get; set; } = new Table<LearjetInteriorMaster>(Names.Tables.Learjet.TableNames.Interior);
        public Table<LearjetManualsMaster> Manuals { get; set; } = new Table<LearjetManualsMaster>(Names.Tables.Learjet.TableNames.Manuals);
        public Table<LearjetManualsEFBMaster> ManualsEFB { get; set; } = new Table<LearjetManualsEFBMaster>(Names.Tables.Learjet.TableNames.ManualsEFB);
        public Table<LearjetOperationDocumentsEquipmentMaster> OperationDocuments { get; set; } = new Table<LearjetOperationDocumentsEquipmentMaster>(Names.Tables.Learjet.TableNames.OPSDocsEquipment);

    }
}
