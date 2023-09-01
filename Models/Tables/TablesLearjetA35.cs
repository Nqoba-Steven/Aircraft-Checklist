using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;

namespace NAC_Aircraft_Checklist.Models.Tables
{
    public class TablesLearjetA35
    {
        public static Dictionary<string, List<string>> Interior = new Dictionary<string, List<string>>()
    {
        {"Interior", new List<string>() {
            "Check the condition of the Cockpit seats",
            "Check the condition of the passenger seats (Armrests, placecards and leather)",
            "Check the condition of the carpets / coin",
            "Check the condition of the cockpit (center console, side panels, dash, windshields and general condition)",
            "Check emergency escapes - some A/C require English and French placecards",
            "Check the condiion of the cargo bay and side panels on the cargo door" }
        },

    };

        public static Dictionary<string, List<string>> Exterior = new Dictionary<string, List<string>>()
    {
         {"Exterior", new List<string>() {
            "Check for any missing or loose screws on the wings and fasteners",
            "Placard on fuselage and emergency exit placard-English / French",
            "Check wing tips condition",
            "Check static wicks",
            "Check for oil leaks, hydraulic leaks and fuel leaks",
            "Condition of leading edges",
            "Condition of paint",
            "Entrance door panels, steps and placards",
            "Condition of windows and wiper",
            "Landing lights and taxi lights",
            "Check condition of landing gears",
            "Check condition of vertical and horizontal stabilisers",
         }
        }
    };
        public static Dictionary<string, List<string>> Cockpit = new Dictionary<string, List<string>>()
    {
            {"Cockpit (35A)", new List<string>()
        {
            "HI-LO Charts(Record chart number and revision)",
            "Inspection Reminder",
            "GPS1",
            "GPS2 (If fitted)",
            "Standby GPS",
            "Standby Compass Swing Card (Annually",
            "Crew O2 Masks x 2",
            "Fireproof Gloves",
            "Smoke Goggles",
            "Fire Extinguisher",
            "Crash Axe ",
            "Crew Life Vests (Diff Colour)",
            "Torches x 2",
            "Satellite tracker S/N:",
            "Windshield Covers",
            "Restrain Kit",
        }

        },
    };

        public static Dictionary<string, List<string>> Cabin = new Dictionary<string, List<string>>()
    {

        {"Cabin (35A)", new List<string>()
        {
            "Signal Strips",
            "Fire Extinguishers",
            "Survival Kit",
            "Life Vests",
            "Hazmat Kit x 2",
            "First Aid Kit/s x 2 Content list inspected outside of First Aid Kit",
            "Portable O2 (if fitted",
            "LOPA’s (Current Config",
            "Pax Briefing Cards (OPS-074a) and Restrictive Material Card (OPS-126) one per seat as per confiq",
            "Megaphone",
            "Spill Kit",
            "Sat Phone",
            "Security Wand & Batteries (Always on A/C)",
            "Seat Belt Extension x 3",
            "Infant Seatbelts x 3",
            "French Emergency Equipment Card (where applicable",
        }
    }
    };
        public static Dictionary<string, List<string>> FlightRedFolder = new Dictionary<string, List<string>>()
    {
        {"Flight (Red) Folder",new List<string>()
        {
            "C of A (Original)",
            "C of R (Original)",
            "Cert of Release to Service (Original)",
            "Inspection Reminder (Original)",
            "Radio Lic. (Original) & Proof of Payment (Copy)",
            "Noise Certificate (Original)",
            "CAA M&B Certificate (Original)",
            "ELT Registration/ Application",
        }
    }
    };

        public static Dictionary<string, List<string>> Manuals = new Dictionary<string, List<string>>()
    {
        {"Manuals (35A)",new List<string>()
        {
            "Crew Check list & QR",
            "Pilots Manual",
            "Aircraft Flight Manual",
            "Check – Master supplement list is in AFM",
        }

    } };
        public static Dictionary<string, List<string>> ManualsEFB = new Dictionary<string, List<string>>()
    {
    {"Manuals EFB (35A)",new List<string>()
    {
        "TFE731 Pilots tip guide",
        "NAC MEL",
        "Sat Track System Manual",
        "Iridium Essentials Guide",
        "Weather Radar Manual",
        "TAWS",
        "NAC 35A Index Cards Manual",
        "FAA – Holdover Times",
        "Emergency Response Guidance for AC incidents (ICAO Red)",
        //"NAC Aircraft SOP",
        
        "NAC SMP Manual",
        "GPS",
        "GPS",
        "GPS",
        "GPS",
        "Radio Systems Guide (HF)",
        "GPS",
        "GPS",
        "GPS",
        "Guardian User Manual 3",
        "Guardian User Manual 5",
        "Silvereye Aviation Admin guide",
        "Silvereye Aviation QRH",
        "TCAS",
        "Emergency Response Guidance for AC incidents (ICAO Red)",
        "ELT Inst & Operation Manual",
        "ELTD AF Integra",
        "NAC Operations Manual",
        "NAC ERP Manual",
        "NAC SMS Manual",
        "NAC SMP Manual",
        "EFB Manual",
        "NAC MEL",
        "NAC MCM",
        "NAC Aircraft SOP",
    }
    }
    };

        public static Dictionary<string, List<string>> OpsDocsEquipment = new Dictionary<string, List<string>>()
    {
        {"OPS Docs & Equipment", new List<string>()
        {
            "Flight Folio (all clear)",
            "Flight Bag",
            "Load Sheets",
            "Told Cards",
            "NAC Pilots Checklist",
            "IPAD (Condition/Updates and screen protector) (Mat)",
        }
        }
    };
        public static Dictionary<string, List<string>> AircraftFlipFile = new Dictionary<string, List<string>>()
    {
        {"Aircraft Flip File (35A)", new List<string>()
        {
            "Flip file Index (Rev Status & Date)",
            "Passenger Briefing (OPS-040)",
            "Certificate of Insurance",
            "Operating Certificate AOC (Certified Copy)",
            "AOC Ops Spec (Certified Copy)",
            "AMO Certificate (Copy)",
            "AMO Ops Spec (Copy)",
            "Int. Air Service License",
            "Aircraft Lease Agreement",
            "AOC & AMO Aircraft Maintenance Agreement",
            "Buckle & Dent Form",
            "Occurrence Forms (x 5) (SMS-001)",
            "NAC Aircraft Equipment List",
            "Temp Export Certificate",
            "Foreign Approvals to Operate (if applicable)",
            "Issued to Member List",
            "All LOPA configurations for the specific Aircraft",
            "AMO M & B Report Form (Renew every 5 years)",
            "Dangerous Goods (OPS-126)",
            "EASA – Authorization (If Applicable)",
            "UK- Authorization (If Applicable)",
        }
        }
    };
        public static Dictionary<string, List<string>> Equipment = new Dictionary<string, List<string>>()
    {
        {"Equipment", new List<string>()
        {
            "A/C Life Raft even it stored at the base UN (Life Raft ELT)",
            //"Hard Bristle Broom",
            "Tail stand",
            "Aircraft Covers",
            "Chocks",
        }
        }
    };

       

    }
    [Table(Names.Tables.Learjet.Master.Interior, Schema = Names.Tables.Learjet.Master.Schema)]
    public class LearjetInteriorMaster : MasterTableEntry
    {
    }
    [Table(Names.Tables.Learjet.Master.AircraftFlipFile, Schema = Names.Tables.Learjet.Master.Schema)]
    public class LearjetAircraftFlipFileMaster : MasterTableEntry
    {
    }
    [Table(Names.Tables.Learjet.Master.Cabin, Schema = Names.Tables.Learjet.Master.Schema)]
    public class LearjetCabinMaster : MasterTableEntry
    {
    }
    [Table(Names.Tables.Learjet.Master.Cockpit, Schema = Names.Tables.Learjet.Master.Schema)]
    public class LearjetCockpitMaster : MasterTableEntry
    {
    }
    [Table(Names.Tables.Learjet.Master.Equipment, Schema = Names.Tables.Learjet.Master.Schema)]
    public class LearjetEquipmentMaster : MasterTableEntry
    {
    }
    [Table(Names.Tables.Learjet.Master.Exterior, Schema = Names.Tables.Learjet.Master.Schema)]
    public class LearjetExteriorMaster : MasterTableEntry
    {
    }
    [Table(Names.Tables.Learjet.Master.FlightFolder, Schema = Names.Tables.Learjet.Master.Schema)]
    public class LearjetFlightFolderMaster : MasterTableEntry
    {
    }
    [Table(Names.Tables.Learjet.Master.Manuals, Schema = Names.Tables.Learjet.Master.Schema)]
    public class LearjetManualsMaster : MasterTableEntry
    {
    }
    [Table(Names.Tables.Learjet.Master.ManualsEFB, Schema = Names.Tables.Learjet.Master.Schema)]
    public class LearjetManualsEFBMaster : MasterTableEntry
    {
    }
    [Table(Names.Tables.Learjet.Master.OperationDocumentsEquipment, Schema = Names.Tables.Learjet.Master.Schema)]
    public class LearjetOperationDocumentsEquipmentMaster : MasterTableEntry
    {
    }
}
