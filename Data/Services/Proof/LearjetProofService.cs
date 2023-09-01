using Microsoft.EntityFrameworkCore;
using NAC_Aircraft_Checklist.Models.Proof.B1900;
using NAC_Aircraft_Checklist.Models.Proof.Document;
using NAC_Aircraft_Checklist.Models.Proof.Learjet;
using System.Linq;

namespace NAC_Aircraft_Checklist.Data.Services.Proof
{
    public class LearjetProofService : ILearjetProofService
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;

        public LearjetProofService(IDbContextFactory<AppDbContext> context)
        {
            _dbContextFactory = context;
        }
        public LearjetProof Add(LearjetProof proof)
        {

            try
            {
                LearjetProof entry = new LearjetProof();
                entry.AircraftId = proof.AircraftId;
                entry.User = proof.User;
                entry.Revision = proof.Revision;
                entry.Date = DateTime.Now;
                entry.BaseOfOperations = proof.BaseOfOperations;

                var context = _dbContextFactory.CreateDbContext();
                context.LearjetProofs.Add(entry);
                context.SaveChanges();

                entry = context.Set<LearjetProof>().SingleOrDefault(a => a.Id == entry.Id);
                return entry;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
        }

        public LearjetProof GetProofByMonth(int aircraftId, DateTime date)
        {

            try
            {
                var context = _dbContextFactory.CreateDbContext();

                var proof = context.LearjetProofs
                    .Where(p => p.AircraftId == aircraftId)
                    .Where(o => o.Date.Month == date.Month)
                    .FirstOrDefault();
                if (proof == null)
                {
                    System.Diagnostics.Debug.WriteLine("No Proof found to create proofread");
                }

                return proof;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }

        }

        public async Task AddProofDocument(LearjetProofDocument document)
        {
            try
            {
                //Write the aircraft id somewhere
                var dbContextCockpits = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Cockpits)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Cockpits");
                    item.ProofID = document.ProofID;
                }
                await dbContextCockpits.LearjetProofCockpit.AddRangeAsync(document.Cockpits);

                var dbContextCabins = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Cabins)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Cabins");
                    item.ProofID = document.ProofID;
                }
                await dbContextCabins.LearjetProofCabin.AddRangeAsync(document.Cabins);

                var dbContextManuals = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Manuals)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Manuals");
                    item.ProofID = document.ProofID;
                }
                await dbContextManuals.LearjetProofManuals.AddRangeAsync(document.Manuals);

                var dbContextManualsIPad = _dbContextFactory.CreateDbContext();
                foreach (var item in document.ManualsEFB)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry ManualsIPad");
                    item.ProofID = document.ProofID;
                }
                dbContextManualsIPad.LearjetProofManualsEFB.AddRange(document.ManualsEFB);

                var dbContextFlightFolders = _dbContextFactory.CreateDbContext();
                foreach (var item in document.FlightFolders)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry FlightFolders");
                    item.ProofID = document.ProofID;
                }
                dbContextFlightFolders.LearjetProofFlightFolder.AddRange(document.FlightFolders);

                var dbContextAircraftFlipFiles = _dbContextFactory.CreateDbContext();
                foreach (var item in document.AircraftFlipFiles)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry FlightFolders");
                    item.ProofID = document.ProofID;
                }
                await dbContextAircraftFlipFiles.LearjetProofAircraftFlipFile.AddRangeAsync(document.AircraftFlipFiles);

                var dbContextOperationDocuments = _dbContextFactory.CreateDbContext();
                foreach (var item in document.OperationDocuments)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry OperationDocuments");
                    item.ProofID = document.ProofID;
                }
                await dbContextOperationDocuments.LearjetProofOperationDocumentsEquipment.AddRangeAsync(document.OperationDocuments);

                var dbContextEquipment = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Equipment)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Equipment");
                    item.ProofID = document.ProofID;
                }
                await dbContextEquipment.LearjetProofEquipment.AddRangeAsync(document.Equipment);

                var dbContextAdditionalItems = _dbContextFactory.CreateDbContext();

                foreach (var item in document.AdditionalItems)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry AdditionalItems");
                    item.ProofID = document.ProofID;
                }
                await dbContextAdditionalItems.LearjetProofAdditionalItems.AddRangeAsync(document.AdditionalItems);

                await dbContextCockpits.SaveChangesAsync();
                await dbContextCabins.SaveChangesAsync();
                await dbContextManuals.SaveChangesAsync();
                await dbContextFlightFolders.SaveChangesAsync();
                await dbContextManualsIPad.SaveChangesAsync();
                await dbContextAircraftFlipFiles.SaveChangesAsync();
                await dbContextOperationDocuments.SaveChangesAsync();
                await dbContextEquipment.SaveChangesAsync();
                await dbContextAdditionalItems.SaveChangesAsync();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Failed to create proof");
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public async Task<IEnumerable<LearjetProof>> GetAll()
        {

                var _context = _dbContextFactory.CreateDbContext();
            return await _context.LearjetProofs.ToListAsync();
        }

        public LearjetProof GetById(int id)
        {
                var _context = _dbContextFactory.CreateDbContext();
            return _context.LearjetProofs.Where(item => item.Id == id).FirstOrDefault();
        }

        public LearjetProof GetLatestProof()
        {
            try
            {
                //Get where 
                var _context = _dbContextFactory.CreateDbContext();
                LearjetProof result = _context.LearjetProofs.OrderByDescending(proof => proof.Id).First<LearjetProof>();
                return result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                System.Diagnostics.Debug.WriteLine("Empty list");
                return new LearjetProof();
            }
        }
        public LearjetProof[][] GroupByMonths()
        {
            try
            {
                var _context = _dbContextFactory.CreateDbContext();
               
                var orderedDocuments = _context.LearjetProofs
                    .OrderBy(e => e.Date)
                    .GroupBy(g => new { g.Date.Year, g.Date.Month })
                    .Select(t => t.ToArray())
                    .ToArray();

                return orderedDocuments;
            }
            catch (Exception e)
            {

                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
        }
        public async Task<LearjetProofDocument> GetLatestProofDocument()
        {
            LearjetProof latestProof = GetLatestProof();
            LearjetProofDocument document = await GetProofDocument(latestProof);
            return document;
        }

        public async Task<LearjetProofDocument> GetProofDocument(LearjetProof proof)
        {
            try
            {
                var _context = _dbContextFactory.CreateDbContext();
                LearjetProofDocument document = new LearjetProofDocument();

                document.AircraftFlipFiles = await _context.LearjetProofAircraftFlipFile.Where(item => item.ProofID == proof.Id).ToListAsync();

                document.Cabins = await _context.LearjetProofCabin.Where(item => item.ProofID == proof.Id).ToListAsync();
                document.Cockpits = await _context.LearjetProofCockpit.Where(item => item.ProofID == proof.Id).ToListAsync();

                document.Equipment = await _context.LearjetProofEquipment.Where(item => item.ProofID == proof.Id).ToListAsync();
                document.Exteriors = await _context.LearjetProofExterior.Where(item => item.ProofID == proof.Id).ToListAsync();

                document.FlightFolders = await _context.LearjetProofFlightFolder.Where(item => item.ProofID == proof.Id).ToListAsync();
                document.Interiors = await _context.LearjetProofInterior.Where(item => item.ProofID == proof.Id).ToListAsync();
                
                document.Manuals = await _context.LearjetProofManuals.Where(item => item.ProofID == proof.Id).ToListAsync();
                document.ManualsEFB = await _context.LearjetProofManualsEFB.Where(item => item.ProofID == proof.Id).ToListAsync();
               
                document.OperationDocuments = await _context.LearjetProofOperationDocumentsEquipment.Where(item => item.ProofID == proof.Id).ToListAsync();
                document.AdditionalItems = await _context.LearjetProofAdditionalItems.Where(item => item.ProofID == proof.Id).ToListAsync();

                return document;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                System.Diagnostics.Debug.WriteLine("Empty Proof");
                return new LearjetProofDocument();
            }
        }
    }
}
