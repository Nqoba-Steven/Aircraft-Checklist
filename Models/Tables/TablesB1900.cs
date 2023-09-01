using System.ComponentModel.DataAnnotations.Schema;
using NAC_Aircraft_Checklist.Util;

namespace NAC_Aircraft_Checklist.Models.Tables
{
    public class TablesB1900
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
            {"Cockpit (1900D)", new List<string>()
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
            "Pilot 1900D Checklist (OPS-029b) x 2",
            "Fire Extinguisher",
            "Visual Interception signals (OPS-137) x 1",
            "Crash Axe ",
            "Crew Life Vests (Diff Colour)",
            "Torches x 2",
            "Satellite tracker S/N:",
            "Airborne Risk Management checklist (RMM 001) x 2",
            "Windshield covers",
            "Control Locks",
            "Restrain kit x 1",
            "Brake On / Off x 1(OPS-010)",
            "Do not Occupy x 2(OPS-138)",
            "1900D System check procedure x 1 (OPS-036)",
        }

        },
    };
        public static Dictionary<string, List<string>> Cabin = new Dictionary<string, List<string>>()
    {

        {"Cabin (1900D)", new List<string>()
        {
            "Signal Strips",
            "Fire Extinguishers",
            "Survival Kit",
            "Life Vests",
            "Hazmat Kit x 2",
            "First Aid Kit/s x 2 Content list inspected outside of First Aid Kit",
            "LOPA’s (Current Config",
            "Pax Briefing Cards (OPS-074a) and Restrictive Material Card (OPS-126) one per seat as per confiq",
            "Megaphone",
            "Spill Kit x 1 (Not part of Hazmat kit)",
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
        {"Manuals (1900D)",new List<string>()
        {
            "Pilots Checklist Normal Procedures",
            "Pilots Operating Manual",
            "Aircraft Flight Manual",
            "Check – Master supplement list is in AFM",
            "(Plastic pocket in back of file (FAA approved supplements))",
        }

    } };
        public static Dictionary<string, List<string>> IpadManuals = new Dictionary<string, List<string>>()
    {
    {"Manuals (IPAD’s FO / PIC -1900D)",new List<string>()
    {
        "NAC MEL",
        "NAC Operations Manual",
        "NAC Aircraft SOP",
        "NAC MCM",
        "NAC Route Guide",
        "NAC ERP Manual",
        "Sat Track System ",
        "Sat Track System ",
        "Iridium Essentials Guide",
        "ELT Manual",
        "NAC SMS Manual",
        "Weather Radar Manual",
        "NAC CASEVAC Operating Procedure",
        "EGWPS/MKV1 (ZS-FAB)",
        "TAWS / EGPWS",
        "NAC B190 Index Cards Manual",
        "TCAS (Pilot’s Guide) (if applicable)",
        "TCAS (System & Install) (if applicable)",
        "TCAS (Pilot Supplement) (if applicable)",
        "FAA – Holdover Times",
        "Emergency Response Guidance for AC incidents (ICAO Red)",
        "NAC SMP Manual",
        "Quick Reference H/Guide(if Applicable)",
        "QRH – Take-Off (if Applicable)",
        "Radio Systems Guide (HF)",
        "GPS",
        "GPS",
        "GPS (Standby)",
        "GPS",
        "GPS",
        "FDR Installation manual (ZS-FAB)",
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
            "IPAD (Condition/Updates and screen protector) (Mat)",
            "IPAD Protective Cover",
        }
        }
    };
        public static Dictionary<string, List<string>> AircraftFlipFile = new Dictionary<string, List<string>>()
    {
        {"Aircraft Flip File (1900D)", new List<string>()
        {
            "Flip file Index (Rev Status & Date) (OPS-082)",
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
            "Contract with the Client (WFP & UN only)",
            "Aviation Safety Occurrence / Hazard Report (x 5) (SMS-001)",
            "NAC Aircraft Equipment List",
            "Temp Export Certificate",
            "Foreign Approvals to Operate (if applicable)",
            "Issued to Member List",
            "All LOPA configurations for the specific Aircraft",
            "AMO M & B Report Form (Renew every 5 years)",
            "B1900 Security Check list (OPS-093a)",
            "Dangerous Goods (OPS-126)",
            "EASA – Authorization (If Applicable)",
            "UK- Authorization (If Applicable)",
            "IATA – Provisions for Dangerous Goods carried by Passengers / Crew",
            "Aircraft IPAD/EFB Login(OPS-139)",
        }
        }
    };
        public static Dictionary<string, List<string>> Equipment = new Dictionary<string, List<string>>()
    {
        {"Equipment", new List<string>()
        {
            "A/C Life Raft even it stored at the base UN (Life Raft ELT)",
            "Hard Bristle Broom",
            "Pull scale",
            "Tail stand",
            "Aircraft Covers",
            "Chocks",
            "Snow Covers",
            "Cigarette Lighter Chargers",
            "Non-Touch Thermometer",
            "Ladder",
            "Insecticide",
            "WFP / UN Call Sign",
            "Rubber refueling mat’s x 2",
        }
        }
    };

        public void BuildTables()
        {
            //Take all the values and persist them as follows
        }


    }


    [Table(Names.Tables.B1900.Master.Interior, Schema = Names.Tables.B1900.Master.Schema)]
    public class B1900InteriorMaster : MasterTableEntry
    {
    }

    [Table(Names.Tables.B1900.Master.Exterior, Schema = Names.Tables.B1900.Master.Schema)]
    public class B1900ExteriorMaster : MasterTableEntry
    {
    }
    [Table(Names.Tables.B1900.Master.Cockpit, Schema = Names.Tables.B1900.Master.Schema)]
    public class B1900CockpitMaster : MasterTableEntry
    {
    }
    [Table(Names.Tables.B1900.Master.Cabin, Schema = Names.Tables.B1900.Master.Schema)]
    public class B1900CabinMaster : MasterTableEntry
    {
    }
    [Table(Names.Tables.B1900.Master.FlightFolder, Schema = Names.Tables.B1900.Master.Schema)]
    public class B1900FlightRedFolderMaster : MasterTableEntry
    {
    }
    [Table(Names.Tables.B1900.Master.Manuals, Schema = Names.Tables.B1900.Master.Schema)]
    public class B1900ManualsMaster : MasterTableEntry
    {
    }
    [Table(Names.Tables.B1900.Master.ManualsIPad, Schema = Names.Tables.B1900.Master.Schema)]
    public class B1900ManualsIPadMaster : MasterTableEntry
    {

    }
    [Table(Names.Tables.B1900.Master.OperationDocuments, Schema = Names.Tables.B1900.Master.Schema)]
    public class B1900OpsDocsEquipmentMaster : MasterTableEntry
    {

    }
    [Table(Names.Tables.B1900.Master.AircraftFlipFile, Schema = Names.Tables.B1900.Master.Schema)]
    public class B1900AircraftFlipFileMaster : MasterTableEntry
    {

    }
    [Table(Names.Tables.B1900.Master.Equipment, Schema = Names.Tables.B1900.Master.Schema)]
    public class B1900EquipmentMaster : MasterTableEntry
    {
    }

    //Build Master Tables by updating all the entries

}
