using Microsoft.EntityFrameworkCore;
using NAC_Aircraft_Checklist.Models;
using NAC_Aircraft_Checklist.Models.Proof.B1900;
using NAC_Aircraft_Checklist.Models.Proof.Document;
using System.Reflection.Metadata;
using System.Collections.Generic;
namespace NAC_Aircraft_Checklist.Data.Services.Proof
{
    public class B1900ProofService : IB1900ProofService
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        public B1900ProofService(IDbContextFactory<AppDbContext> context)
        {
            _dbContextFactory = context;
        }

        public async Task AddProofDocument(B1900ProofDocument document)
        {
            //Get Create new Proof then add document
            //Get Proof last id and incre
            try
            {

                var dbContextCockpits = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Cockpits)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Cockpits");
                    item.ProofID = document.ProofID;
                }
                await dbContextCockpits.B1900ProofCockpits.AddRangeAsync(document.Cockpits);

                var dbContextCabins = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Cabins)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Cabins");
                    item.ProofID = document.ProofID;
                }
                await dbContextCabins.B1900ProofCabins.AddRangeAsync(document.Cabins);

                var dbContextManuals = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Manuals)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Manuals");
                    item.ProofID = document.ProofID;
                }
                await dbContextManuals.B1900ProofManuals.AddRangeAsync(document.Manuals);

                var dbContextManualsIPad = _dbContextFactory.CreateDbContext();
                foreach (var item in document.ManualsIPad)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry ManualsIPad");
                    item.ProofID = document.ProofID;
                }
                dbContextManualsIPad.B1900ProofManualsIPad.AddRange(document.ManualsIPad);

                var dbContextFlightFolders = _dbContextFactory.CreateDbContext();
                foreach (var item in document.FlightFolders)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry FlightFolders");
                    item.ProofID = document.ProofID;
                }
                dbContextFlightFolders.B1900ProofFlightFolders.AddRange(document.FlightFolders);

                var dbContextAircraftFlipFiles = _dbContextFactory.CreateDbContext();
                foreach (var item in document.AircraftFlipFiles)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry FlightFolders");
                    item.ProofID = document.ProofID;
                }
                await dbContextAircraftFlipFiles.B1900ProofAircraftFlipFiles.AddRangeAsync(document.AircraftFlipFiles);

                var dbContextOperationDocuments = _dbContextFactory.CreateDbContext();
                foreach (var item in document.OperationDocuments)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry OperationDocuments");
                    item.ProofID = document.ProofID;
                }
                await dbContextOperationDocuments.B1900ProofOperationDocuments.AddRangeAsync(document.OperationDocuments);

                var dbContextEquipment = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Equipment)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Equipment");
                    item.ProofID = document.ProofID;
                }
                await dbContextEquipment.B1900ProofEquipment.AddRangeAsync(document.Equipment);

                var dbContextAdditionalItems = _dbContextFactory.CreateDbContext();

                foreach (var item in document.AdditionalItems)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry AdditionalItems");
                    item.ProofID = document.ProofID;
                }
                await dbContextAdditionalItems.B1900ProofAdditionalItems.AddRangeAsync(document.AdditionalItems);

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
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine($"Proof Document loaded {document.ProofID}");
            }

        }
        public async Task<B1900ProofDocument> GetProofDocument(B1900Proof proof)
        {
            try
            {
                var _context = _dbContextFactory.CreateDbContext();
                var AircraftFlipFiles = await _context.B1900ProofAircraftFlipFiles.Where(item => item.ProofID == proof.Id).ToListAsync();
                var Cabins = await _context.B1900ProofCabins.Where(item => item.ProofID == proof.Id).ToListAsync();
                var Cockpits = await _context.B1900ProofCockpits.Where(item => item.ProofID == proof.Id).ToListAsync();
                var Equipments = await _context.B1900ProofEquipment.Where(item => item.ProofID == proof.Id).ToListAsync();
                //var Exteriors = await _context.B1900ProofExteriors.Where(item => item.ProofID == proof.Id).ToListAsync();
                var FlightFolders = await _context.B1900ProofFlightFolders.Where(item => item.ProofID == proof.Id).ToListAsync();
                //var Interiors = await _context.B1900ProofInteriors.Where(item => item.ProofID == proof.Id).ToListAsync();
                var Manuals = await _context.B1900ProofManuals.Where(item => item.ProofID == proof.Id).ToListAsync();
                var ManualsIPad = await _context.B1900ProofManualsIPad.Where(item => item.ProofID == proof.Id).ToListAsync();
                var OperationDocuments = await _context.B1900ProofOperationDocuments.Where(item => item.ProofID == proof.Id).ToListAsync();
                var AdditionalItems = await _context.B1900ProofAdditionalItems.Where(item => item.ProofID == proof.Id).ToListAsync();

                B1900ProofDocument document = new B1900ProofDocument();
                document.CompletedBy = proof.User;
                document.BaseOfOperations = proof.BaseOfOperations;

                document.AdditionalItems = AdditionalItems;
                document.AircraftFlipFiles = AircraftFlipFiles;
                document.Cabins = Cabins;
                document.Cockpits = Cockpits;
                document.Equipment = Equipments;
                //document.Exteriors = Exteriors;
                document.FlightFolders = FlightFolders;
                //document.Interiors = Interiors;
                document.Manuals = Manuals;
                document.ManualsIPad = ManualsIPad;
                document.OperationDocuments = OperationDocuments;

                return document;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                System.Diagnostics.Debug.WriteLine("Empty Proof");
                return new B1900ProofDocument();
            }
        }

        public B1900Proof Add(B1900Proof proof)
        {
            try
            {
                B1900Proof entry = new B1900Proof();
                entry.AircraftId = proof.AircraftId;
                entry.User = proof.User;
                entry.Revision = proof.Revision;
                entry.Date = DateTime.Now;
                entry.BaseOfOperations = proof.BaseOfOperations;

                var context = _dbContextFactory.CreateDbContext();
                context.B1900Proofs.Add(entry);
                context.SaveChanges();

                entry = context.Set<B1900Proof>().SingleOrDefault(a => a.Id == entry.Id);
                return entry;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
        }


        public async Task<IEnumerable<B1900Proof>> GetAll()
        {
            try
            {
                var context = _dbContextFactory.CreateDbContext();
                //Get where 
                var result = await context.B1900Proofs.ToListAsync();
                return result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                System.Diagnostics.Debug.WriteLine("Empty list");
                return new List<B1900Proof>();
            }
        }

        public B1900Proof GetLatestProof()
        {
            try
            {
                var context = _dbContextFactory.CreateDbContext();
                //Get where 
                B1900Proof result = context.B1900Proofs.OrderByDescending(proof => proof.Id).First<B1900Proof>();
                return result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                System.Diagnostics.Debug.WriteLine("Empty list");
                return new B1900Proof();
            }
        }
        public B1900Proof GetLatestProof(int aircraftId)
        {
            try
            {
                var context = _dbContextFactory.CreateDbContext();
                //Get where 
                B1900Proof result = context.B1900Proofs.Where(item => item.AircraftId == aircraftId).OrderByDescending(item => item.Id).FirstOrDefault();

                //B1900Proof result = context.B1900Proofs.OrderByDescending(proof => proof.Id).First<B1900Proof>();
                return result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                System.Diagnostics.Debug.WriteLine("Empty list");
                return new B1900Proof();
            }
        }
        public B1900Proof[][] GroupByMonths()
        {
            try
            {
                var context = _dbContextFactory.CreateDbContext();
                var orderedDocuments = context.B1900Proofs
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
        public B1900Proof GetProofByMonth( int aircraftId, DateTime date)
        {

            try
            {
                var context = _dbContextFactory.CreateDbContext();

                var proof = context.B1900Proofs
                    .Where(p => p.AircraftId == aircraftId)
                    .Where(o => o.Date.Month == date.Month)
                    .FirstOrDefault();
                if (proof == null) {
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
        public B1900Proof GetById(int id)
        {
            var context = _dbContextFactory.CreateDbContext();

            B1900Proof result = context.B1900Proofs.OrderByDescending(proof => proof.Id == id).First<B1900Proof>();
            if (result != null)
                return result;
            else
                return new B1900Proof();
        }

        public async Task<B1900ProofDocument> GetLatestProofDocument(int aircraftId)
        {
            B1900Proof latestProof = GetLatestProof(aircraftId);
            B1900ProofDocument document = await GetProofDocument(latestProof);
            return document;
        }
    }
}
