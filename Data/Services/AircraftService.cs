using Microsoft.EntityFrameworkCore;
using NAC_Aircraft_Checklist.Controllers;
using NAC_Aircraft_Checklist.Models.Email;
using NAC_Aircraft_Checklist.Models.Entities;

namespace NAC_Aircraft_Checklist.Data.Services
{
    public class AircraftService : IAircraftService
    {
        private readonly AppDbContext _context;
        public AircraftService(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public void Add(Aircraft aircraft)
        {
            try
            {
                _context.Add<Aircraft>(aircraft);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);

            }
        }

        public void Delete(int id)
        {
            try
            {
                Aircraft r = _context.Aircrafts.FirstOrDefault(aircraft => aircraft.Id == id);
                if (r != null)
                {
                    _context.Aircrafts.Attach(r);
                    _context.Aircrafts.Remove(r);
                    _context.SaveChanges();
                    System.Diagnostics.Debug.WriteLine("Aircraft deleted");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"PlannerRecipients Recipient Failed to deleted {id}");
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public void Delete(Aircraft aircraft)
        {
            try
            {
                Aircraft r = _context.Aircrafts.FirstOrDefault(a => a.Id == aircraft.Id);
                if (r != null)
                {
                    _context.Aircrafts.Attach(r);
                    _context.Aircrafts.Remove(r);
                    _context.SaveChanges();
                    System.Diagnostics.Debug.WriteLine("Aircraft deleted");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Aircraft Failed to deleted {aircraft.Id}");
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public async Task<IEnumerable<Aircraft>> GetAll()
        {
            try
            {
                var result = await _context.Aircrafts.ToListAsync();
                return result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
        }

        public Aircraft GetById(int id)
        {
            Aircraft result =  (Aircraft)_context.Aircrafts.Where(aircraft => aircraft.Id == id).FirstOrDefault();
            if (result == null) { 
                System.Diagnostics.Debug.WriteLine("No Aircraft Found");
                return new Aircraft();
            }
            return result;
        }

        public Aircraft Update(int id,Aircraft aircraftUpdate)
        {
            try
            {
                var result = _context.Aircrafts.SingleOrDefault(r => r.Id == id);

                if (result == null)
                {
                    System.Diagnostics.Debug.WriteLine("Failed to Update: Aircraft not found");

                    return null;
                }
                _context.Entry(result).CurrentValues.SetValues(aircraftUpdate);
                _context.SaveChanges();
                return result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                    return null;
            }
        }

        public bool Exists(string reg)
        {
            bool exists;
            var aircraft = _context.Aircrafts.FirstOrDefault(a => a.Reg.Equals(reg));
            exists = aircraft == null ? false : true;
            System.Diagnostics.Debug.WriteLine($"Does element exist: {exists}");
            return exists;
        }

        public async Task<IEnumerable<Aircraft>> GetByType(string type)
        {
            var result = await _context.Aircrafts.Where(aircraft => aircraft.Type.ToLower().Contains(type.ToLower())).ToListAsync();
            return result;
        }
    }
}
