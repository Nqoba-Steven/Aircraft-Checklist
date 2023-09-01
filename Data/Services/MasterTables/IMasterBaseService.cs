using NAC_Aircraft_Checklist.Models.Entities;

namespace NAC_Aircraft_Checklist.Data.Services.MasterTables
{
    public interface IMasterBaseService<T>
    {
        void Build(List<string> list,int revision);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAll(int rev);
        Aircraft GetById(int id);
        void Add(T t);
        Aircraft Update(int id, T t);

        void Delete(int id);
        void Delete(T t);
        bool Exists(string name);
    }
}
