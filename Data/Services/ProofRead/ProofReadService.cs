using Microsoft.EntityFrameworkCore;
using NAC_Aircraft_Checklist.Models;
using NAC_Aircraft_Checklist.Models.Documents;
using NAC_Aircraft_Checklist.Models.Proof.Document;
using NAC_Aircraft_Checklist.Models.ProofRead;
using NAC_Aircraft_Checklist.Models.ProofRead.B1900;
using NAC_Aircraft_Checklist.Models.ProofRead.Learjet;
using System.Reflection.Metadata;

namespace NAC_Aircraft_Checklist.Data.Services.ProofRead
{
    public class ProofReadService : IProofReadService
    {
        
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        public ProofReadService(IDbContextFactory<AppDbContext> context)
        {
            _dbContextFactory = context;
        }
        public async void AddB1900ProofReadDocument(B1900ProofReadDocument document)
        {
            try
            {
                B1900ProofReadEntry entry = new B1900ProofReadEntry();
                var _context = _dbContextFactory.CreateDbContext();

                var entryID = -1;
                if (document.entry != null)
                {
                    entry.ProofId = document.entry.ProofId;
                    entry.EntryId = document.entry.EntryId;
                    _context.B1900ProofReadEntries.Add(entry);
                    _context.SaveChanges();
                    entryID = entry.Id;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead interiors");
                }

                /*
                if (document.interiors.Count > 0)

                    if (document.interiors.Count > 0)
                    {
                        //for each add entry
                        foreach (var item in document.interiors)
                        {
                            item.ProofReadId = entryID;
                        }
                        await _context.B1900ProofReadInterior.AddRangeAsync(document.interiors);

                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Failed to load ProofRead interiors");
                    }

                if (document.exteriors.Count > 0)
                {
                    foreach (var item in document.exteriors)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.B1900ProofReadExterior.AddRangeAsync(document.exteriors);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead exteriors");
                }
                */
                if (document.Cockpits.Count > 0)
                {
                    foreach (var item in document.Cockpits)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.B1900ProofReadCockpits.AddRangeAsync(document.Cockpits);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead cockpits");
                }

                if (document.Cabins.Count > 0)
                {
                    foreach (var item in document.Cabins)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.B1900ProofReadCabins.AddRangeAsync(document.Cabins);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead interiors");
                }

                if (document.FlightFolder.Count > 0)
                {
                    foreach (var item in document.FlightFolder)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.B1900ProofReadFlightFolder.AddRangeAsync(document.FlightFolder);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead flightFolder");
                }

                if (document.Manuals.Count > 0)
                {
                    foreach (var item in document.Manuals)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.B1900ProofReadManuals.AddRangeAsync(document.Manuals);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead manuals");
                }

                if (document.ManualsIpad.Count > 0)
                {
                    foreach (var item in document.ManualsIpad)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.B1900ProofReadManualsIPad.AddRangeAsync(document.ManualsIpad);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead manualsEFB");
                }

                if (document.AircraftFlipFile.Count > 0)
                {
                    foreach (var item in document.AircraftFlipFile)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.B1900ProofReadAircraftFlipFiles.AddRangeAsync(document.AircraftFlipFile);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead aircraftFlipFile");
                }

                if (document.Equipment.Count > 0)
                {
                    foreach (var item in document.Equipment)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.B1900ProofReadEquipment.AddRangeAsync(document.Equipment);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead equipment");
                }

                if (document.OperationDocuments.Count > 0)
                {
                    foreach (var item in document.OperationDocuments)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.B1900ProofReadOperationDocuments.AddRangeAsync(document.OperationDocuments);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead operationDocuments");
                }

                if (document.AdditionalItems.Count > 0)
                {
                    foreach (var item in document.AdditionalItems)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.B1900ProofReadAdditionalItems.AddRangeAsync(document.AdditionalItems);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead interiors");
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Failed to create a proof read document");
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public async void AddLearjetProofReadDocument(LearjetProofReadDocument document)
        {
            try
            {
                LearjetProofReadEntry entry = new LearjetProofReadEntry();
                var _context = _dbContextFactory.CreateDbContext();
                var entryID = -1;
                if (document.entry != null)
                {

                    entry.ProofId = document.entry.ProofId;
                    entry.EntryId = document.entry.EntryId;
                    _context.LearjetProofReadEntries.Add(entry);
                    _context.SaveChanges();
                    entryID = entry.Id;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead interiors");
                }

                if (document.interiors.Count > 0)
                {
                    foreach (var item in document.interiors)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.LearjetProofReadInteriors.AddRangeAsync(document.interiors);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead interiors");
                }

                if (document.exteriors.Count > 0)
                {
                    foreach (var item in document.exteriors)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.LearjetProofReadExteriors.AddRangeAsync(document.exteriors);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead exteriors");
                }

                if (document.Cockpits.Count > 0)
                {
                    foreach (var item in document.Cockpits)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.LearjetProofReadCockpits.AddRangeAsync(document.Cockpits);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead cockpits");
                }

                if (document.Cabins.Count > 0)
                {
                    foreach (var item in document.Cabins)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.LearjetProofReadCabins.AddRangeAsync(document.Cabins);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead interiors");
                }

                if (document.FlightFolder.Count > 0)
                {
                    foreach (var item in document.FlightFolder)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.LearjetProofReadFlightFolders.AddRangeAsync(document.FlightFolder);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead flightFolder");
                }

                if (document.Manuals.Count > 0)
                {
                    foreach (var item in document.Manuals)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.LearjetProofReadManuals.AddRangeAsync(document.Manuals);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead manuals");
                }

                if (document.ManualsEFB.Count > 0)
                {
                    foreach (var item in document.ManualsEFB)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.LearjetProofReadManualsEFBs.AddRangeAsync(document.ManualsEFB);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead manualsEFB");
                }

                if (document.AircraftFlipFile.Count > 0)
                {
                    foreach (var item in document.AircraftFlipFile)
                    {
                        item.ProofReadId = entryID;
                    }
                    _context.LearjetProofReadAircraftFlipFiles.AddRangeAsync(document.AircraftFlipFile);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead aircraftFlipFile");
                }

                if (document.Equipment.Count > 0)
                {
                    foreach (var item in document.Equipment)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.LearjetProofReadEquipment.AddRangeAsync(document.Equipment);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead equipment");
                }

                if (document.OperationDocuments.Count > 0)
                {
                    foreach (var item in document.OperationDocuments)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.LearjetProofReadOperationDocumentsEquipment.AddRangeAsync(document.OperationDocuments);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead operationDocuments");
                }

                if (document.AdditionalItems.Count > 0)
                {
                    foreach (var item in document.AdditionalItems)
                    {
                        item.ProofReadId = entryID;
                    }
                    await _context.LearjetProofReadAdditionalItems.AddRangeAsync(document.AdditionalItems);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Failed to load ProofRead interiors");
                }


            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Failed to create a proof read document");
                System.Diagnostics.Debug.WriteLine(e);
            }


        }

        public B1900ProofReadDocument CreateProofRead1900( B1900ProofDocument proofDocument, B1900Document checklist)
        {
            var _context = _dbContextFactory.CreateDbContext();
            try
            {
                B1900ProofReadDocument proofReadDocument = new B1900ProofReadDocument(proofDocument, checklist);
                return  proofReadDocument;
            }
            catch (Exception e) {
                System.Diagnostics.Debug.WriteLine("Error creating 1900 Proof Read Document");
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
        }

        public B1900ProofReadDocument CreateProofRead1900(B1900MasterListPayload proofMaster, B1900MasterListPayload entryMaster, B1900ProofDocument proofDocument, B1900Document checklist)
        {
            var _context = _dbContextFactory.CreateDbContext();
            try
            {
                B1900ProofReadDocument proofReadDocument = new B1900ProofReadDocument(proofMaster,entryMaster,proofDocument, checklist);
                return proofReadDocument;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Error creating 1900 Proof Read Document");
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
        }

        public LearjetProofReadDocument CreateProofReadLearjet(LearjetProofDocument proofDocument, LearjetDocument checklist)
        {
            var _context = _dbContextFactory.CreateDbContext();
            try
            {
                LearjetProofReadDocument proofReadDocument = new LearjetProofReadDocument(proofDocument, checklist);
                return proofReadDocument;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Error creating Learjet Proof Read Document");
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
        }

        public async Task<IEnumerable<B1900ProofReadEntry>> GetAllB1900ProofReadDocuments()
        {
                var _context = _dbContextFactory.CreateDbContext();
            return await _context.B1900ProofReadEntries.ToListAsync();
        }


        public async Task<IEnumerable<LearjetProofReadEntry>> GetAllLearjetProofReadDocuments()
        {
                var _context = _dbContextFactory.CreateDbContext();
            return await _context.LearjetProofReadEntries.ToListAsync();
        }

        public async Task<B1900ProofReadDocument> GetByIdB1900ProofReadDocument(int id)
        {
            B1900ProofReadDocument document = new B1900ProofReadDocument();
            var _context = _dbContextFactory.CreateDbContext();

            try
            {
                B1900ProofReadEntry entry = _context.B1900ProofReadEntries.Where(item => item.Id == id).FirstOrDefault();
                document.entry = entry;
                int proofReadId = entry.Id;
                //document.interiors = await _context.B1900ProofReadInterior.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                //document.exteriors = await _context.B1900ProofReadExterior.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.Cockpits = await _context.B1900ProofReadCockpits.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.Cabins = await _context.B1900ProofReadCabins.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.FlightFolder = await _context.B1900ProofReadFlightFolder.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.Manuals = await _context.B1900ProofReadManuals.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.ManualsIpad = await _context.B1900ProofReadManualsIPad.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.Equipment = await _context.B1900ProofReadEquipment.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.AircraftFlipFile = await _context.B1900ProofReadAircraftFlipFiles.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.OperationDocuments = await _context.B1900ProofReadOperationDocuments.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.AdditionalItems = await _context.B1900ProofReadAdditionalItems.Where(item => item.ProofReadId == proofReadId).ToListAsync();

                return document;

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                System.Diagnostics.Debug.WriteLine("Error Failed");
            }

            return document;
        }

        public async Task<LearjetProofReadDocument> GetByIdLearjetProofReadDocument(int id)
        {
            LearjetProofReadDocument document = new LearjetProofReadDocument();
            var _context = _dbContextFactory.CreateDbContext();

            try
            {
                LearjetProofReadEntry entry = _context.LearjetProofReadEntries.Where(item => item.Id == id).FirstOrDefault();
                document.entry = entry;
                int proofReadId = entry.Id;
                document.interiors = await _context.LearjetProofReadInteriors.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.exteriors = await _context.LearjetProofReadExteriors.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.Cockpits = await _context.LearjetProofReadCockpits.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.Cabins = await _context.LearjetProofReadCabins.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.FlightFolder = await _context.LearjetProofReadFlightFolders.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.Manuals = await _context.LearjetProofReadManuals.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.ManualsEFB = await _context.LearjetProofReadManualsEFBs.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.Equipment = await _context.LearjetProofReadEquipment.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.AircraftFlipFile = await _context.LearjetProofReadAircraftFlipFiles.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.OperationDocuments = await _context.LearjetProofReadOperationDocumentsEquipment.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                document.AdditionalItems = await _context.LearjetProofReadAdditionalItems.Where(item => item.ProofReadId == proofReadId).ToListAsync();
                return document;

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                System.Diagnostics.Debug.WriteLine("Error Failed");
            }

            return document;
        }
    }
}
