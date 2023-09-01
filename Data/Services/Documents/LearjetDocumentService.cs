using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using NAC_Aircraft_Checklist.Models.Documents;
using NAC_Aircraft_Checklist.Models.Entry.B1900;
using NAC_Aircraft_Checklist.Models.Entry.Learjet;

namespace NAC_Aircraft_Checklist.Data.Services.Documents
{
    public class LearjetDocumentService : ILearjetDocumentService
    {

        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        public LearjetDocumentService(IDbContextFactory<AppDbContext> dbContext)
        {
            _dbContextFactory = dbContext;
        }
        public async Task Add(LearjetDocument document)
        {
            LearjetEntry entry = CreateEntry(document.LearjetEntry);

            //Use this to set the id;
            try
            {
                var dbContextInteriors = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Interiors)
                {
                    item.EntryId = entry.Id;
                    System.Diagnostics.Debug.WriteLine("Writing Entry Interiors");
                }
                await dbContextInteriors.LearjetInterior.AddRangeAsync(document.Interiors);
                //Document Tables
                var dbContextExteriors = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Exteriors)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Exteriors");
                    item.EntryId = entry.Id;
                }
                await dbContextExteriors.LearjetExterior.AddRangeAsync(document.Exteriors);

                var dbContextCockpits = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Cockpits)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Cockpits");
                    item.EntryId = entry.Id;
                }
                await dbContextCockpits.LearjetCockpit.AddRangeAsync(document.Cockpits);

                var dbContextCabins = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Cabins)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Cabins");
                    item.EntryId = entry.Id;
                }
                await dbContextCabins.LearjetCabin.AddRangeAsync(document.Cabins);

                var dbContextManuals = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Manuals)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Manuals");
                    item.EntryId = entry.Id;
                }
                await dbContextManuals.LearjetManuals.AddRangeAsync(document.Manuals);

                var dbContextManualsIPad = _dbContextFactory.CreateDbContext();
                foreach (var item in document.ManualsEFB)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry ManualsIPad");
                    item.EntryId = entry.Id;
                }
                dbContextManualsIPad.LearjetManualsEFB.AddRange(document.ManualsEFB);

                var dbContextFlightFolders = _dbContextFactory.CreateDbContext();
                foreach (var item in document.FlightFolders)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry FlightFolders");
                    item.EntryId = entry.Id;
                }
                dbContextFlightFolders.LearjetFlightFolder.AddRange(document.FlightFolders);

                var dbContextAircraftFlipFiles = _dbContextFactory.CreateDbContext();
                foreach (var item in document.AircraftFlipFiles)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry FlightFolders");
                    item.EntryId = entry.Id;
                }
                await dbContextAircraftFlipFiles.LearjetAircraftFlipFile.AddRangeAsync(document.AircraftFlipFiles);

                var dbContextOperationDocuments = _dbContextFactory.CreateDbContext();
                foreach (var item in document.OperationDocuments)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry OperationDocuments");
                    item.EntryId = entry.Id;
                }
                await dbContextOperationDocuments.LearjetOperationDocumentsEquipment.AddRangeAsync(document.OperationDocuments);

                var dbContextEquipment = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Equipment)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Equipment");
                    item.EntryId = entry.Id;
                }
                await dbContextEquipment.LearjetEquipment.AddRangeAsync(document.Equipment);

                var dbContextAdditionalItems = _dbContextFactory.CreateDbContext();

                foreach (var item in document.AdditionalItems)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry AdditionalItems");
                    item.EntryId = entry.Id;
                }
                await dbContextAdditionalItems.LearjetAdditionalItem.AddRangeAsync(document.AdditionalItems);

                await dbContextExteriors.SaveChangesAsync();
                await dbContextInteriors.SaveChangesAsync();
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
            }

        }

        public LearjetEntry CreateEntry(LearjetEntry e)
        {
            LearjetEntry entry = new LearjetEntry();
            entry.AircraftId = e.AircraftId;
            entry.CompletedBy = e.CompletedBy;
            entry.Revision = e.Revision;
            entry.Date = DateTime.Now;
            entry.BaseOfOperations = e.BaseOfOperations;
            //Save
            var dbContextEntries = _dbContextFactory.CreateDbContext();

            dbContextEntries.Set<LearjetEntry>().Add(entry);
            dbContextEntries.LearjetEntry.Add(entry);
            dbContextEntries.SaveChanges();
            entry = dbContextEntries.Set<LearjetEntry>().SingleOrDefault(a => a.Id == entry.Id);
            //Get this entry which was just created;
            return entry;
        }

        public async Task<LearjetDocument> GetByID(int id)
        {
            try
            {
                var _context = _dbContextFactory.CreateDbContext();
                LearjetDocument document = new LearjetDocument();

                //var AircraftFlipFiles = await _context.B1900ProofAircraftFlipFiles.Where(item => item.ProofID == proof.Id).ToListAsync();
                LearjetEntry entry = await _context.LearjetEntry.Where(item => item.Id == id).FirstOrDefaultAsync();

                document.LearjetEntry.Revision = entry.Revision;
                document.Aircraft = await _context.Aircrafts.Where(a => a.Id == entry.AircraftId).FirstOrDefaultAsync();

                document.LearjetEntry.BaseOfOperations = document.Aircraft.BaseOfOperations;
                document.LearjetEntry.Date = entry.Date;
                document.LearjetEntry.CompletedBy = entry.CompletedBy;

                document.Interiors = await _context.LearjetInterior.Where(item => item.EntryId == entry.Id).ToListAsync();
                document.Exteriors = await _context.LearjetExterior.Where(item => item.EntryId == entry.Id).ToListAsync();
                document.Cockpits = await _context.LearjetCockpit.Where(item => item.EntryId == entry.Id).ToListAsync();
                document.Cabins = await _context.LearjetCabin.Where(item => item.EntryId == entry.Id).ToListAsync();
                document.FlightFolders = await _context.LearjetFlightFolder.Where(item => item.EntryId == entry.Id).ToListAsync();
                document.Manuals = await _context.LearjetManuals.Where(item => item.EntryId == entry.Id).ToListAsync();
                document.ManualsEFB = await _context.LearjetManualsEFB.Where(item => item.EntryId == entry.Id).ToListAsync();
                document.OperationDocuments = await _context.LearjetOperationDocumentsEquipment.Where(item => item.EntryId == entry.Id).ToListAsync();
                document.AircraftFlipFiles = await _context.LearjetAircraftFlipFile.Where(item => item.EntryId == entry.Id).ToListAsync();
                document.Equipment = await _context.LearjetEquipment.Where(item => item.EntryId == entry.Id).ToListAsync();
                document.AdditionalItems = await _context.LearjetAdditionalItem.Where(item => item.EntryId == entry.Id).ToListAsync();

                return document;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
        }
        public async Task<IEnumerable<LearjetEntry>> GetEntries()
        {
            var _context = _dbContextFactory.CreateDbContext();
            return await _context.LearjetEntry.ToListAsync();
        }
        public LearjetEntry[][] GroupEntriesByDate()
        {
            try
            {
                var context = _dbContextFactory.CreateDbContext();
                var orderedDocuments = context.LearjetEntry
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
    }
}
