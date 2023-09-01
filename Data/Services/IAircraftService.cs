using NAC_Aircraft_Checklist.Controllers;
using NAC_Aircraft_Checklist.Models;
using NAC_Aircraft_Checklist.Models.Entities;

namespace NAC_Aircraft_Checklist.Data.Services
{
    public interface IAircraftService
    {
        Task<IEnumerable<Aircraft>> GetAll();
        Aircraft GetById(int id);
        Task<IEnumerable<Aircraft>> GetByType(string type);
        void Add(Aircraft aircraft);
        Aircraft Update(int id, Aircraft aircraft);

        void Delete(int id);
        void Delete(Aircraft aircraft);
        bool Exists(string aircraft);

    }
}
