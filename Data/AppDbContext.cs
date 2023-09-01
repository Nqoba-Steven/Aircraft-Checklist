using Microsoft.EntityFrameworkCore;
using NAC_Aircraft_Checklist.Models.Entities;
using NAC_Aircraft_Checklist.Models.Tables;
using NAC_Aircraft_Checklist.Models.Proof.B1900;
using NAC_Aircraft_Checklist.Models.Email;
using NAC_Aircraft_Checklist.Models.Proof.Learjet;
using NAC_Aircraft_Checklist.Models.Entry.B1900;
using NAC_Aircraft_Checklist.Models.Entry.Learjet;
using NAC_Aircraft_Checklist.Models.Entry.Revisions;
using NAC_Aircraft_Checklist.Models.ProofRead.Learjet;
using NAC_Aircraft_Checklist.Models.ProofRead;
using NAC_Aircraft_Checklist.Models.ProofRead.B1900;
using NAC_Aircraft_Checklist.Models.Email.Logger;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using NAC_Aircraft_Checklist.Models.Users;

namespace NAC_Aircraft_Checklist.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        #region Identity
        
        #endregion
        /** Email **/
        /** Revisions**/
        #region Revision
        public DbSet<B1900Revision> B1900Revision { get; set; }
        public DbSet<LearjetRevision> LearjetRevision { get; set; }
        #endregion
        #region MasterList
        public DbSet<B1900InteriorMaster> B1900InteriorMasterList { get; set; }
        public DbSet<B1900ExteriorMaster> B1900ExteriorMasterList { get; set; }
        public DbSet<B1900CockpitMaster> B1900CockpitMasterList { get; set; }
        public DbSet<B1900CabinMaster> B1900CabinMasterList { get; set; }
        public DbSet<B1900FlightRedFolderMaster> B1900FlightRedFolderMasterList { get; set; }
        public DbSet<B1900ManualsMaster> B1900ManualsMasterList { get; set; }
        public DbSet<B1900ManualsIPadMaster> B1900ManualsIPadMasterList { get; set; }
        public DbSet<B1900OpsDocsEquipmentMaster> B1900OpsDocsEquipmentMasterList { get; set; }
        public DbSet<B1900AircraftFlipFileMaster> B1900AircraftFlipFileMasterList { get; set; }
        public DbSet<B1900EquipmentMaster> B1900EquipmentMasterList { get; set; }

        /** Learjet **/
        public DbSet<LearjetInteriorMaster> LearjetInteriorMasterList { get; set; }
        public DbSet<LearjetExteriorMaster> LearjetExteriorMasterList { get; set; }
        public DbSet<LearjetCockpitMaster> LearjetCockpitMasterList { get; set; }
        public DbSet<LearjetCabinMaster> LearjetCabinMasterList { get; set; }
        public DbSet<LearjetFlightFolderMaster> LearjetFlightFolderMasterList { get; set; }
        public DbSet<LearjetManualsMaster> LearjetManualsMasterList { get; set; }
        public DbSet<LearjetManualsEFBMaster> LearjetManualsEFBMasterList { get; set; }
        public DbSet<LearjetOperationDocumentsEquipmentMaster> LearjetOperationDocumentsEquipmentMasterList { get; set; }
        public DbSet<LearjetAircraftFlipFileMaster> LearjetAircraftFlipFileMasterList { get; set; }
        public DbSet<LearjetEquipmentMaster> LearjetEquipmentMasterList { get; set; }
        #endregion
        #region Proofs
        public DbSet<B1900Proof> B1900Proofs { get; set; }
        public DbSet<B1900ProofAdditionalItems> B1900ProofAdditionalItems { get; set; }
        public DbSet<B1900ProofAircraftFlipFile> B1900ProofAircraftFlipFiles { get; set; }
        public DbSet<B1900ProofCabin> B1900ProofCabins { get; set; }
        public DbSet<B1900ProofCockpit> B1900ProofCockpits { get; set; }
        public DbSet<B1900ProofEquipment> B1900ProofEquipment { get; set; }
        public DbSet<B1900ProofExterior> B1900ProofExteriors { get; set; }
        public DbSet<B1900ProofFlightFolder> B1900ProofFlightFolders { get; set; }
        public DbSet<B1900ProofInterior> B1900ProofInteriors { get; set; }
        public DbSet<B1900ProofManuals> B1900ProofManuals { get; set; }
        public DbSet<B1900ProofManualsIPad> B1900ProofManualsIPad { get; set; }
        public DbSet<B1900ProofOperationDocuments> B1900ProofOperationDocuments { get; set; }


        public DbSet<LearjetProof> LearjetProofs { get; set; }
        public DbSet<LearjetProofAdditionalItem> LearjetProofAdditionalItems { get; set; }
        public DbSet<LearjetProofAircraftFlipFile> LearjetProofAircraftFlipFile { get; set; }
        public DbSet<LearjetProofCabin> LearjetProofCabin { get; set; }
        public DbSet<LearjetProofCockpit> LearjetProofCockpit { get; set; }
        public DbSet<LearjetProofEquipment> LearjetProofEquipment { get; set; }
        public DbSet<LearjetProofExterior> LearjetProofExterior { get; set; }
        public DbSet<LearjetProofFlightFolder> LearjetProofFlightFolder { get; set; }
        public DbSet<LearjetProofInterior> LearjetProofInterior { get; set; }
        public DbSet<LearjetProofManuals> LearjetProofManuals { get; set; }
        public DbSet<LearjetProofManualsEFB> LearjetProofManualsEFB { get; set; }
        public DbSet<LearjetProofOperationDocumentsEquipment> LearjetProofOperationDocumentsEquipment { get; set; }



        #endregion
        #region Aircrafts
        public DbSet<Aircraft> Aircrafts { get; set; }
        #endregion
        #region Entries
        public DbSet<B1900Entry> B1900Entry { get; set; }
        public DbSet<B1900Interior> B1900Interiors { get; set; }
        public DbSet<B1900Exterior> B1900Exteriors { get; set; }
        public DbSet<B1900Cockpit> B1900Cockpit { get; set; }
        public DbSet<B1900Cabin> B1900Cabin { get; set; }
        public DbSet<B1900FlightFolder> B1900FlightFolder { get; set; }
        public DbSet<B1900Manuals> B1900Manuals { get; set; }
        public DbSet<B1900ManualsIPad> B1900ManualsIpad { get; set; }
        public DbSet<B1900OperationDocuments> B1900OperationDocuments { get; set; }
        public DbSet<B1900AircraftFlipFile> B1900AircraftFlipFile { get; set; }
        public DbSet<B1900Equipment> B1900Equipment { get; set; }
        public DbSet<B1900AdditionalItems> B1900AdditionalItems { get; set; }
        /** Learjet **/
        public DbSet<LearjetEntry> LearjetEntry { get; set; }
        public DbSet<LearjetAdditionalItem> LearjetAdditionalItem { get; set; }

        public DbSet<LearjetAircraftFlipFile> LearjetAircraftFlipFile { get; set; }

        public DbSet<LearjetCabin> LearjetCabin { get; set; }

        public DbSet<LearjetCockpit> LearjetCockpit { get; set; }
        public DbSet<LearjetEquipment> LearjetEquipment { get; set; }
        public DbSet<LearjetExterior> LearjetExterior { get; set; }
        public DbSet<LearjetFlightFolder> LearjetFlightFolder { get; set; }
        public DbSet<LearjetInterior> LearjetInterior { get; set; }
        public DbSet<LearjetManuals> LearjetManuals { get; set; }
        public DbSet<LearjetManualsEFB> LearjetManualsEFB { get; set; }
        public DbSet<LearjetOperationDocumentsEquipment> LearjetOperationDocumentsEquipment { get; set; }
        #endregion
        #region Proof Read

        public DbSet<B1900ProofReadEntry> B1900ProofReadEntries { get; set; }
        public DbSet<B1900ProofReadAircraftFlipFile> B1900ProofReadAircraftFlipFiles { get; set; }
        public DbSet<B1900ProofReadCabin> B1900ProofReadCabins { get; set; }
        public DbSet<B1900ProofReadCockpit> B1900ProofReadCockpits { get; set; }
        public DbSet<B1900ProofReadEquipment> B1900ProofReadEquipment { get; set; }
        public DbSet<B1900ProofReadExterior> B1900ProofReadExterior { get; set; }
        public DbSet<B1900ProofReadFlightFolder> B1900ProofReadFlightFolder { get; set; }
        public DbSet<B1900ProofReadInterior> B1900ProofReadInterior { get; set; }
        public DbSet<B1900ProofReadManuals> B1900ProofReadManuals { get; set; }
        public DbSet<B1900ProofReadManualsIPad> B1900ProofReadManualsIPad { get; set; }
        public DbSet<B1900ProofReadOperationDocuments> B1900ProofReadOperationDocuments { get; set; }
        public DbSet<B1900ProofReadAdditionalItems> B1900ProofReadAdditionalItems { get; set; }

        public DbSet<LearjetProofReadEntry> LearjetProofReadEntries { get; set; }
        public DbSet<LearjetProofReadAdditionalItem> LearjetProofReadAdditionalItems { get; set; }
        public DbSet<LearjetProofReadAircraftFlipFile> LearjetProofReadAircraftFlipFiles { get; set; }
        public DbSet<LearjetProofReadCabin> LearjetProofReadCabins { get; set; }
        public DbSet<LearjetProofReadCockpit> LearjetProofReadCockpits { get; set; }
        public DbSet<LearjetProofReadEquipment> LearjetProofReadEquipment { get; set; }
        public DbSet<LearjetProofReadExterior> LearjetProofReadExteriors { get; set; }
        public DbSet<LearjetProofReadFlightFolder> LearjetProofReadFlightFolders { get; set; }
        public DbSet<LearjetProofReadInterior> LearjetProofReadInteriors { get; set; }
        public DbSet<LearjetProofReadManuals> LearjetProofReadManuals { get; set; }
        public DbSet<LearjetProofReadManualsEFB> LearjetProofReadManualsEFBs { get; set; }
        public DbSet<LearjetProofReadOperationDocumentsEquipment> LearjetProofReadOperationDocumentsEquipment { get; set; }
        #endregion
        #region Logger
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<EscalationLog> EscalationLogs { get; set; }
        public DbSet<ProofLog> ProofLogs { get; set; }
        public DbSet<RevisionLog> RevisionLogs { get; set; }
        public DbSet<ReminderLog> ReminderLogs { get; set; }
        public DbSet<UploadLog> UploadLogs { get; set; }
        public DbSet<WelcomeLog> WelcomeLogs { get; set; }
        #endregion
        #region Email
        public DbSet<EscalationRecipient> EscalationRecipients { get; set; }
        public DbSet<PlannerRecipient> PlannerRecipients { get; set; }
        public DbSet<BaseManagerRecipient> BaseManagerRecipients { get; set; }
        public DbSet<UploadWaitList> UploadWaitList { get; set; }

        #endregion

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Revision
            modelBuilder.Entity<B1900Revision>().HasKey(revision => new
            {
                revision.Id,
            });
            modelBuilder.Entity<LearjetRevision>().HasKey(revision => new
            {
                revision.Id,
            });
            #endregion
            #region Master Lists
            modelBuilder.Entity<B1900InteriorMaster>().HasKey(list => new
            {
                list.Id,
            });
            modelBuilder.Entity<B1900ExteriorMaster>().HasKey(list => new
            {
                list.Id,
            });

            modelBuilder.Entity<B1900CockpitMaster>().HasKey(list => new
            {
                list.Id,
            });
            modelBuilder.Entity<B1900CabinMaster>().HasKey(list => new
            {
                list.Id,
            });

            modelBuilder.Entity<B1900FlightRedFolderMaster>().HasKey(list => new
            {
                list.Id,
            });

            modelBuilder.Entity<B1900ManualsMaster>().HasKey(list => new
            {
                list.Id,
            });
            modelBuilder.Entity<B1900ManualsIPadMaster>().HasKey(list => new
            {
                list.Id,
            });

            modelBuilder.Entity<B1900OpsDocsEquipmentMaster>().HasKey(list => new
            {
                list.Id,
            });
            modelBuilder.Entity<B1900AircraftFlipFileMaster>().HasKey(list => new
            {
                list.Id,
            });
            modelBuilder.Entity<B1900EquipmentMaster>().HasKey(list => new
            {
                list.Id,
            });
            //Learjet
            modelBuilder.Entity<LearjetAircraftFlipFileMaster>().HasKey(list => new
            {
                list.Id,
            });
            modelBuilder.Entity<LearjetCabinMaster>().HasKey(list => new
            {
                list.Id,
            }); modelBuilder.Entity<LearjetCockpitMaster>().HasKey(list => new
            {
                list.Id,
            }); modelBuilder.Entity<LearjetEquipmentMaster>().HasKey(list => new
            {
                list.Id,
            }); modelBuilder.Entity<LearjetExteriorMaster>().HasKey(list => new
            {
                list.Id,
            }); modelBuilder.Entity<LearjetFlightFolderMaster>().HasKey(list => new
            {
                list.Id,
            }); modelBuilder.Entity<LearjetInteriorMaster>().HasKey(list => new
            {
                list.Id,
            }); modelBuilder.Entity<LearjetManualsMaster>().HasKey(list => new
            {
                list.Id,
            }); modelBuilder.Entity<LearjetManualsEFBMaster>().HasKey(list => new
            {
                list.Id,
            }); modelBuilder.Entity<LearjetOperationDocumentsEquipmentMaster>().HasKey(list => new
            {
                list.Id,
            });
            #endregion
            #region Proofs
            modelBuilder.Entity<B1900ProofAdditionalItems>().HasKey(proof => new
            {
                proof.Id,
            });
            modelBuilder.Entity<B1900ProofAircraftFlipFile>().HasKey(proof => new
            {
                proof.Id,
            });
            modelBuilder.Entity<B1900ProofCabin>().HasKey(proof => new
            {
                proof.Id,
            });

            modelBuilder.Entity<B1900ProofCockpit>().HasKey(proof => new
            {
                proof.Id,
            });
            modelBuilder.Entity<B1900ProofEquipment>().HasKey(proof => new
            {
                proof.Id,
            });
            modelBuilder.Entity<B1900ProofExterior>().HasKey(proof => new
            {
                proof.Id,
            });
            modelBuilder.Entity<B1900ProofFlightFolder>().HasKey(proof => new
            {
                proof.Id,
            });
            modelBuilder.Entity<B1900ProofInterior>().HasKey(proof => new
            {
                proof.Id,
            });
            modelBuilder.Entity<B1900ProofManuals>().HasKey(proof => new
            {
                proof.Id,
            });
            modelBuilder.Entity<B1900ProofManualsIPad>().HasKey(proof => new
            {
                proof.Id,
            });
            modelBuilder.Entity<B1900ProofOperationDocuments>().HasKey(proof => new
            {
                proof.Id,
            });

            //LearJet

            modelBuilder.Entity<LearjetProof>().HasKey(proof => new
            {
                proof.Id,
            });
            modelBuilder.Entity<LearjetProofAdditionalItem>().HasKey(proof => new
            {
                proof.Id,
            });
            modelBuilder.Entity<LearjetProofAircraftFlipFile>().HasKey(proof => new
            {
                proof.Id,
            }); modelBuilder.Entity<LearjetProofCabin>().HasKey(proof => new
            {
                proof.Id,
            }); modelBuilder.Entity<LearjetProofCockpit>().HasKey(proof => new
            {
                proof.Id,
            }); modelBuilder.Entity<LearjetProofEquipment>().HasKey(proof => new
            {
                proof.Id,
            }); modelBuilder.Entity<LearjetProofExterior>().HasKey(proof => new
            {
                proof.Id,
            }); modelBuilder.Entity<LearjetProofFlightFolder>().HasKey(proof => new
            {
                proof.Id,
            }); modelBuilder.Entity<LearjetProofInterior>().HasKey(proof => new
            {
                proof.Id,
            }); modelBuilder.Entity<LearjetProofManuals>().HasKey(proof => new
            {
                proof.Id,
            }); modelBuilder.Entity<LearjetProofManualsEFB>().HasKey(proof => new
            {
                proof.Id,
            });
            modelBuilder.Entity<LearjetProofOperationDocumentsEquipment>().HasKey(proof => new
            {
                proof.Id,
            });

            #endregion
            #region Proof Read
            modelBuilder.Entity<B1900ProofReadEntry>().HasKey(proofRead => new
            {
                proofRead.Id,
            });
            modelBuilder.Entity<B1900ProofReadAdditionalItems>().HasKey(proofRead => new
            {
                proofRead.Id,
            }); modelBuilder.Entity<B1900ProofReadAircraftFlipFile>().HasKey(proofRead => new
            {
                proofRead.Id,
            }); modelBuilder.Entity<B1900ProofReadCabin>().HasKey(proofRead => new
            {
                proofRead.Id,
            }); modelBuilder.Entity<B1900ProofReadCockpit>().HasKey(proofRead => new
            {
                proofRead.Id,
            }); modelBuilder.Entity<B1900ProofReadEquipment>().HasKey(proofRead => new
            {
                proofRead.Id,
            }); modelBuilder.Entity<B1900ProofReadExterior>().HasKey(proofRead => new
            {
                proofRead.Id,
            }); modelBuilder.Entity<B1900ProofReadFlightFolder>().HasKey(proofRead => new
            {
                proofRead.Id,
            }); modelBuilder.Entity<B1900ProofReadInterior>().HasKey(proofRead => new
            {
                proofRead.Id,
            }); modelBuilder.Entity<B1900ProofReadManuals>().HasKey(proofRead => new
            {
                proofRead.Id,
            }); modelBuilder.Entity<B1900ProofReadManualsIPad>().HasKey(proofRead => new
            {
                proofRead.Id,
            });
            modelBuilder.Entity<B1900ProofReadOperationDocuments>().HasKey(proofRead => new
            {
                proofRead.Id,
            });

            //Learjet
            modelBuilder.Entity<LearjetProofReadEntry>().HasKey(proofRead => new
            {
                proofRead.Id,
            });
            modelBuilder.Entity<LearjetProofReadAircraftFlipFile>().HasKey(proofRead => new
            {
                proofRead.Id,
            });
            modelBuilder.Entity<LearjetProofReadCabin>().HasKey(proofRead => new
            {
                proofRead.Id,
            });
            modelBuilder.Entity<LearjetProofReadCockpit>().HasKey(proofRead => new
            {
                proofRead.Id,
            });
            modelBuilder.Entity<LearjetProofReadEquipment>().HasKey(proofRead => new
            {
                proofRead.Id,
            });
            modelBuilder.Entity<LearjetProofReadExterior>().HasKey(proofRead => new
            {
                proofRead.Id,
            });
            modelBuilder.Entity<LearjetProofReadInterior>().HasKey(proofRead => new
            {
                proofRead.Id,
            });
            modelBuilder.Entity<LearjetProofReadFlightFolder>().HasKey(proofRead => new
            {
                proofRead.Id,
            });
            modelBuilder.Entity<LearjetProofReadManuals>().HasKey(proofRead => new
            {
                proofRead.Id,
            });
            modelBuilder.Entity<LearjetProofReadManualsEFB>().HasKey(proofRead => new
            {
                proofRead.Id,
            });
            modelBuilder.Entity<LearjetProofReadOperationDocumentsEquipment>().HasKey(proofRead => new
            {
                proofRead.Id,
            });
            modelBuilder.Entity<LearjetProofReadAdditionalItem>().HasKey(proofRead => new
            {
                proofRead.Id,
            });

            #endregion
            #region Aircrafts
            modelBuilder.Entity<Aircraft>().HasKey(aircraft => new
            {
                aircraft.Id,
                aircraft.Reg,
            });
            #endregion
            #region Entries

            modelBuilder.Entity<B1900Entry>().HasKey(entry => new
            {
                entry.Id,
            });
            modelBuilder.Entity<B1900Exterior>().HasKey(exterior => new
            {
                exterior.Id,
            });
            modelBuilder.Entity<B1900Interior>().HasKey(interior => new
            {
                interior.Id,
            });
            modelBuilder.Entity<B1900Cockpit>().HasKey(cockpit => new
            {
                cockpit.Id,
            });
            modelBuilder.Entity<B1900Cabin>().HasKey(cabin => new
            {
                cabin.Id,
            });
            modelBuilder.Entity<B1900FlightFolder>().HasKey(flightFolder => new
            {
                flightFolder.Id,
            });
            modelBuilder.Entity<B1900Manuals>().HasKey(manuals => new
            {
                manuals.Id,
            });
            modelBuilder.Entity<B1900ManualsIPad>().HasKey(manuals => new
            {
                manuals.Id,
            });
            modelBuilder.Entity<B1900OperationDocuments>().HasKey(opDocs => new
            {
                opDocs.Id,
            });
            modelBuilder.Entity<B1900AircraftFlipFile>().HasKey(flipFile => new
            {
                flipFile.Id,
            });

            modelBuilder.Entity<B1900Equipment>().HasKey(equipment => new
            {
                equipment.Id,
            });
            modelBuilder.Entity<B1900AdditionalItems>().HasKey(item => new
            {
                item.Id,
            });
            //Learjet
            modelBuilder.Entity<LearjetAdditionalItem>().HasKey(item => new
            {
                item.Id,
            });
            modelBuilder.Entity<LearjetAircraftFlipFile>().HasKey(item => new
            {
                item.Id,
            });
            modelBuilder.Entity<LearjetCabin>().HasKey(item => new
            {
                item.Id,
            });
            modelBuilder.Entity<LearjetCockpit>().HasKey(item => new
            {
                item.Id,
            });
            modelBuilder.Entity<LearjetEntry>().HasKey(item => new
            {
                item.Id,
            });
            modelBuilder.Entity<LearjetEquipment>().HasKey(item => new
            {
                item.Id,
            });
            modelBuilder.Entity<LearjetExterior>().HasKey(item => new
            {
                item.Id,
            });
            modelBuilder.Entity<LearjetFlightFolder>().HasKey(item => new
            {
                item.Id,
            });
            modelBuilder.Entity<LearjetInterior>().HasKey(item => new
            {
                item.Id,
            });
            modelBuilder.Entity<LearjetManuals>().HasKey(item => new
            {
                item.Id,
            });
            modelBuilder.Entity<LearjetManualsEFB>().HasKey(item => new
            {
                item.Id,
            });
            modelBuilder.Entity<LearjetOperationDocumentsEquipment>().HasKey(item => new
            {
                item.Id,
            });
            #endregion
            #region Logger
            modelBuilder.Entity<ErrorLog>().HasKey(log => new
            {
                log.Id,
            });
            modelBuilder.Entity<EscalationLog>().HasKey(log => new
            {
                log.Id,
            });
            modelBuilder.Entity<ProofLog>().HasKey(log => new
            {
                log.Id,
            });
            modelBuilder.Entity<ReminderLog>().HasKey(log => new
            {
                log.Id,
            });
            modelBuilder.Entity<RevisionLog>().HasKey(log => new
            {
                log.Id,
            });
            modelBuilder.Entity<UploadLog>().HasKey(log => new
            {
                log.Id,
            });
            modelBuilder.Entity<WelcomeLog>().HasKey(log => new
            {
                log.Id,
            });
            #endregion
            #region Email
            modelBuilder.Entity<BaseManagerRecipient>().HasKey(recipient => new
            {
                recipient.Id,
                recipient.EmailAddress
            });
            modelBuilder.Entity<EscalationRecipient>().HasKey(recipient => new
            {
                recipient.Id,
                recipient.EmailAddress
            }); modelBuilder.Entity<PlannerRecipient>().HasKey(recipient => new
            {
                recipient.Id,
                recipient.EmailAddress
            }); modelBuilder.Entity<UploadWaitList>().HasKey(recipient => new
            {
                recipient.Id,
                recipient.EmailAddress
            });
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
