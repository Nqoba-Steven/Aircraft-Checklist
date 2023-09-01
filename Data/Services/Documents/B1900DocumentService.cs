using Microsoft.EntityFrameworkCore;
using NAC_Aircraft_Checklist.Models.Documents;
using NAC_Aircraft_Checklist.Models.Entities;
using NAC_Aircraft_Checklist.Models.Entry.B1900;
using System.Reflection.Metadata;

namespace NAC_Aircraft_Checklist.Data.Services.Documents
{
    public class B1900DocumentService : IB1900DocumentService
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        public B1900DocumentService(IDbContextFactory<AppDbContext> dbContext)
        {
            _dbContextFactory = dbContext;
        }
        public B1900Entry CreateEntry(B1900Entry e)
        {

            B1900Entry entry = new B1900Entry();
            entry.AircraftId = e.AircraftId;
            entry.CompletedBy = e.CompletedBy;
            entry.Revision = e.Revision;
            entry.Date = DateTime.Now;
            entry.BaseOfOperations = e.BaseOfOperations;
            //Save
            var dbContextEntries = _dbContextFactory.CreateDbContext();

            dbContextEntries.Set<B1900Entry>().Add(entry);
            dbContextEntries.B1900Entry.Add(entry);
            dbContextEntries.SaveChanges();
            entry = dbContextEntries.Set<B1900Entry>().SingleOrDefault(a => a.Id == entry.Id);
            //Get this entry which was just created;
            return entry;
        }


        public B1900Entry[][] GroupEntriesByDate()
        {
            try
            {
                var context = _dbContextFactory.CreateDbContext();
                var orderedDocuments = context.B1900Entry
                    .OrderBy(e => e.Date)
                    .GroupBy(g => new { g.Date.Year, g.Date.Month })
                    .Select(t => t.ToArray())
                    .ToArray();

                return orderedDocuments;
            }
            catch (Exception e) {

                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
        }
        public async Task Add(B1900Document document)
        {
            //Create new Entry
            B1900Entry entry = CreateEntry(document.B1900Entry);

            //Use this to set the id;
            try
            {
                var dbContextInteriors = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Interiors)
                {
                    item.EntryId = entry.Id;
                    System.Diagnostics.Debug.WriteLine("Writing Entry Interiors");
                }
                await dbContextInteriors.B1900Interiors.AddRangeAsync(document.Interiors);
                //Document Tables
                var dbContextExteriors = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Exteriors)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Exteriors");
                    item.EntryId = entry.Id;
                }
                await dbContextExteriors.B1900Exteriors.AddRangeAsync(document.Exteriors);

                var dbContextCockpits = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Cockpits)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Cockpits");
                    item.EntryId = entry.Id;
                }
                await dbContextCockpits.B1900Cockpit.AddRangeAsync(document.Cockpits);

                var dbContextCabins = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Cabins)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Cabins");
                    item.EntryId = entry.Id;
                }
                await dbContextCabins.B1900Cabin.AddRangeAsync(document.Cabins);

                var dbContextManuals = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Manuals)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Manuals");
                    item.EntryId = entry.Id;
                }
                await dbContextManuals.B1900Manuals.AddRangeAsync(document.Manuals);

                var dbContextManualsIPad = _dbContextFactory.CreateDbContext();
                foreach (var item in document.ManualsIPad)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry ManualsIPad");
                    item.EntryId = entry.Id;
                }
                dbContextManualsIPad.B1900ManualsIpad.AddRange(document.ManualsIPad);

                var dbContextFlightFolders = _dbContextFactory.CreateDbContext();
                foreach (var item in document.FlightFolders)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry FlightFolders");
                    item.EntryId = entry.Id;
                }
                dbContextFlightFolders.B1900FlightFolder.AddRange(document.FlightFolders);

                var dbContextAircraftFlipFiles = _dbContextFactory.CreateDbContext();
                foreach (var item in document.AircraftFlipFiles)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry FlightFolders");
                    item.EntryId = entry.Id;
                }
                await dbContextAircraftFlipFiles.B1900AircraftFlipFile.AddRangeAsync(document.AircraftFlipFiles);

                var dbContextOperationDocuments = _dbContextFactory.CreateDbContext();
                foreach (var item in document.OperationDocuments)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry OperationDocuments");
                    item.EntryId = entry.Id;
                }
                await dbContextOperationDocuments.B1900OperationDocuments.AddRangeAsync(document.OperationDocuments);

                var dbContextEquipment = _dbContextFactory.CreateDbContext();
                foreach (var item in document.Equipment)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry Equipment");
                    item.EntryId = entry.Id;
                }
                await dbContextEquipment.B1900Equipment.AddRangeAsync(document.Equipment);

                var dbContextAdditionalItems = _dbContextFactory.CreateDbContext();

                foreach (var item in document.AdditionalItems)
                {
                    System.Diagnostics.Debug.WriteLine("Writing Entry AdditionalItems");
                    item.EntryId = entry.Id;
                }
                await dbContextAdditionalItems.B1900AdditionalItems.AddRangeAsync(document.AdditionalItems);

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

        public async Task<B1900Document> GetByID(int id)
        {
            B1900Document document = new B1900Document();

            //var AircraftFlipFiles = await _context.B1900ProofAircraftFlipFiles.Where(item => item.ProofID == proof.Id).ToListAsync();
            System.Diagnostics.Debug.WriteLine("Entry ID: " + id);
            var _context = _dbContextFactory.CreateDbContext();
            B1900Entry entry = _context.B1900Entry.Where(item => item.Id == id).FirstOrDefault();

            System.Diagnostics.Debug.WriteLine(entry);
            document.B1900Entry = entry;
            document.Aircraft = await _context.Aircrafts.Where(a => a.Id == entry.AircraftId).FirstOrDefaultAsync();
            document.Interiors = await _context.B1900Interiors.Where(item => item.EntryId == entry.Id).ToListAsync();
            document.Exteriors = await _context.B1900Exteriors.Where(item => item.EntryId == entry.Id).ToListAsync();
            document.Cockpits = await _context.B1900Cockpit.Where(item => item.EntryId == entry.Id).ToListAsync();
            document.Cabins = await _context.B1900Cabin.Where(item => item.EntryId == entry.Id).ToListAsync();
            document.FlightFolders = await _context.B1900FlightFolder.Where(item => item.EntryId == entry.Id).ToListAsync();
            document.Manuals = await _context.B1900Manuals.Where(item => item.EntryId == entry.Id).ToListAsync();
            document.ManualsIPad = await _context.B1900ManualsIpad.Where(item => item.EntryId == entry.Id).ToListAsync();
            document.OperationDocuments = await _context.B1900OperationDocuments.Where(item => item.EntryId == entry.Id).ToListAsync();
            document.AircraftFlipFiles = await _context.B1900AircraftFlipFile.Where(item => item.EntryId == entry.Id).ToListAsync();
            document.Equipment = await _context.B1900Equipment.Where(item => item.EntryId == entry.Id).ToListAsync();
            document.AdditionalItems = await _context.B1900AdditionalItems.Where(item => item.EntryId == entry.Id).ToListAsync();
            return document;
        }

        public async Task<IEnumerable<B1900Entry>> GetEntries()
        {
            var _context = _dbContextFactory.CreateDbContext();
            return await _context.B1900Entry.ToListAsync();
        }
    }
}
