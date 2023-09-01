using Microsoft.EntityFrameworkCore;
using NAC_Aircraft_Checklist.Models.Entry.Revisions;
using NAC_Aircraft_Checklist.Models.Tables;
using static NAC_Aircraft_Checklist.Util.Names.Tables;

namespace NAC_Aircraft_Checklist.Data.Services.Revision
{
    public class RevisionService : IRevisionService
    {
        AppDbContext _context;
        public RevisionService(AppDbContext context)
        {
            _context = context;
        }

        public bool AddB1900Revision(B1900Revision revision)
        {
            try
            {
                var exists = _context.B1900Revision.Where(rev => rev.RevisionNumber == revision.RevisionNumber).FirstOrDefault();
                if (exists == null)
                {
                    _context.B1900Revision.Add(revision);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Failed to create Revision: B1900 Revison {revision.RevisionNumber} already exists ");
                    return false;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
            }

        }
        
        public bool AddLearjetRevision(LearjetRevision revision)
        {
            try
            {
                var exists = _context.LearjetRevision.Where(rev => rev.RevisionNumber == revision.RevisionNumber).FirstOrDefault();
                if (exists == null)
                {
                    _context.LearjetRevision.Add(revision);
                    _context.SaveChanges();
                    return true;

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Failed to create Revision: Learjet Revison {revision.RevisionNumber} already exists ");
                    return false;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
            }
        }

        public async Task<IEnumerable<B1900Revision>> GetAllB1900Revisions()
        {
            try
            {
                var result = await _context.B1900Revision.ToListAsync();
                return result;

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Error No B1900 Revisions found");
                System.Diagnostics.Debug.WriteLine(e);
            }
            return null;
        }

        public async Task<IEnumerable<LearjetRevision>> GetAllLearjetRevisions()
        {
            try
            {
                var result = await _context.LearjetRevision.ToListAsync();
                return result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Error No Learjet Revisions found");
                System.Diagnostics.Debug.WriteLine(e);
            }
            return null;
        }

        public B1900Revision GetB1900RevisionById(int id)
        {
            try
            {
                var result = _context.B1900Revision.Where(rev => rev.Id == id).FirstOrDefault();
                return result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return null;
        }
        public B1900Revision GetB1900Revision(int number)
        {
            try
            {
                var result = _context.B1900Revision.Where(rev => rev.RevisionNumber == number).FirstOrDefault();
                return result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return null;
        }
        public B1900Revision GetLatestB1900Revision()
        {
            try
            {
                var result = _context.B1900Revision.OrderByDescending(item => item.RevisionNumber).ToList().FirstOrDefault();
                return result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return null;
        }

        public LearjetRevision GetLatestLearjetRevision()
        {
            try
            {

                var result = _context.LearjetRevision.ToList().OrderByDescending(item=>item.RevisionNumber).FirstOrDefault();
                return result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return null;
        }

        public LearjetRevision GetLearjetRevision(int id)
        {
            try
            {

                var result = _context.LearjetRevision.Where(rev => rev.Id == id).FirstOrDefault();
                return result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return null;

        }
    }
}
