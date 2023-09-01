using Microsoft.EntityFrameworkCore;
using NAC_Aircraft_Checklist.Models.Entities;
using NAC_Aircraft_Checklist.Models.Tables;

namespace NAC_Aircraft_Checklist.Data.Services.MasterTables
{
    public class B1900MasterService
    {
        public class MasterInteriorListService : IMasterBaseService<B1900InteriorMaster>
        {
            private readonly AppDbContext _context;
            public MasterInteriorListService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(B1900InteriorMaster t)
            {
                //Append the new Item to the list
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {

                foreach (var item in list)
                {
                    //Check the revision

                    var checkedItem = _context.B1900InteriorMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        B1900InteriorMaster i = new B1900InteriorMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(B1900InteriorMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<B1900InteriorMaster>> GetAll()
            {
                try
                {
                    var result = await _context.B1900InteriorMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }

            public async Task<IEnumerable<B1900InteriorMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.B1900InteriorMasterList.Where(item => item.Revision == rev).ToListAsync();
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
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, B1900InteriorMaster t)
            {
                throw new NotImplementedException();
            }
        }
        public class MasterExteriorListService : IMasterBaseService<B1900ExteriorMaster>
        {
            private readonly AppDbContext _context;
            public MasterExteriorListService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(B1900ExteriorMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.B1900ExteriorMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        B1900ExteriorMaster i = new B1900ExteriorMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(B1900ExteriorMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<B1900ExteriorMaster>> GetAll()
            {
                try
                {
                    var result = await _context.B1900ExteriorMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }

            public async Task<IEnumerable<B1900ExteriorMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.B1900ExteriorMasterList.Where(item => item.Revision == rev).ToListAsync();
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
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, B1900ExteriorMaster t)
            {
                throw new NotImplementedException();
            }
        }

        public class MasterCockpitService : IMasterBaseService<B1900CockpitMaster>
        {
            private readonly AppDbContext _context;
            public MasterCockpitService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(B1900CockpitMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.B1900CockpitMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        B1900CockpitMaster i = new B1900CockpitMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(B1900CockpitMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<B1900CockpitMaster>> GetAll()
            {
                try
                {
                    var result = await _context.B1900CockpitMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }

            public async Task<IEnumerable<B1900CockpitMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.B1900CockpitMasterList.Where(item => item.Revision == rev).ToListAsync();
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
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, B1900CockpitMaster t)
            {
                throw new NotImplementedException();
            }
        }

        public class MasterCabinService : IMasterBaseService<B1900CabinMaster>
        {
            private readonly AppDbContext _context;
            public MasterCabinService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(B1900CabinMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.B1900CabinMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        B1900CabinMaster i = new B1900CabinMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(B1900CabinMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<B1900CabinMaster>> GetAll()
            {
                try
                {
                    var result = await _context.B1900CabinMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                };
            }

            public async Task<IEnumerable<B1900CabinMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.B1900CabinMasterList.Where(item => item.Revision == rev).ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                };
            }

            public Aircraft GetById(int id)
            {
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, B1900CabinMaster t)
            {
                throw new NotImplementedException();
            }
        }

        public class MasterFlightFolderService : IMasterBaseService<B1900FlightRedFolderMaster>
        {
            private readonly AppDbContext _context;
            public MasterFlightFolderService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(B1900FlightRedFolderMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.B1900FlightRedFolderMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        B1900FlightRedFolderMaster i = new B1900FlightRedFolderMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(B1900FlightRedFolderMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<B1900FlightRedFolderMaster>> GetAll()
            {
                try
                {
                    var result = await _context.B1900FlightRedFolderMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }

            public async Task<IEnumerable<B1900FlightRedFolderMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.B1900FlightRedFolderMasterList.Where(item => item.Revision == rev).ToListAsync();
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
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, B1900FlightRedFolderMaster t)
            {
                throw new NotImplementedException();
            }
        }

        public class MasterManualsService : IMasterBaseService<B1900ManualsMaster>
        {
            private readonly AppDbContext _context;
            public MasterManualsService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(B1900ManualsMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.B1900ManualsMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        B1900ManualsMaster i = new B1900ManualsMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(B1900ManualsMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<B1900ManualsMaster>> GetAll()
            {
                try
                {
                    var result = await _context.B1900ManualsMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }

            public async Task<IEnumerable<B1900ManualsMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.B1900ManualsMasterList.Where(item => item.Revision == rev).ToListAsync();
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
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, B1900ManualsMaster t)
            {
                throw new NotImplementedException();
            }
        }
        public class MasterManualsIPadService : IMasterBaseService<B1900ManualsIPadMaster>
        {
            private readonly AppDbContext _context;
            public MasterManualsIPadService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(B1900ManualsIPadMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.B1900ManualsIPadMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        B1900ManualsIPadMaster i = new B1900ManualsIPadMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(B1900ManualsIPadMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<B1900ManualsIPadMaster>> GetAll()
            {
                try
                {
                    var result = await _context.B1900ManualsIPadMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }

            public async Task<IEnumerable<B1900ManualsIPadMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.B1900ManualsIPadMasterList.Where(item => item.Revision == rev).ToListAsync();
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
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, B1900ManualsIPadMaster t)
            {
                throw new NotImplementedException();
            }
        }

        public class MasterOpsDocsService : IMasterBaseService<B1900OpsDocsEquipmentMaster>
        {
            private readonly AppDbContext _context;
            public MasterOpsDocsService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(B1900OpsDocsEquipmentMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.B1900OpsDocsEquipmentMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        B1900OpsDocsEquipmentMaster i = new B1900OpsDocsEquipmentMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(B1900OpsDocsEquipmentMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<B1900OpsDocsEquipmentMaster>> GetAll()
            {
                try
                {
                    var result = await _context.B1900OpsDocsEquipmentMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                };
            }

            public async Task<IEnumerable<B1900OpsDocsEquipmentMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.B1900OpsDocsEquipmentMasterList.Where(item => item.Revision == rev).ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                };
            }

            public Aircraft GetById(int id)
            {
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, B1900OpsDocsEquipmentMaster t)
            {
                throw new NotImplementedException();
            }
        }
        public class MasterAircraftFlipFileService : IMasterBaseService<B1900AircraftFlipFileMaster>
        {
            private readonly AppDbContext _context;
            public MasterAircraftFlipFileService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(B1900AircraftFlipFileMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.B1900AircraftFlipFileMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        B1900AircraftFlipFileMaster i = new B1900AircraftFlipFileMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(B1900AircraftFlipFileMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<B1900AircraftFlipFileMaster>> GetAll()
            {
                try
                {
                    var result = await _context.B1900AircraftFlipFileMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                };
            }

            public async Task<IEnumerable<B1900AircraftFlipFileMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.B1900AircraftFlipFileMasterList.Where(item => item.Revision == rev).ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                };
            }

            public Aircraft GetById(int id)
            {
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, B1900AircraftFlipFileMaster t)
            {
                throw new NotImplementedException();
            }
        }

        public class MasterEquipmentService : IMasterBaseService<B1900EquipmentMaster>
        {
            private readonly AppDbContext _context;
            public MasterEquipmentService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(B1900EquipmentMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.B1900EquipmentMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        B1900EquipmentMaster i = new B1900EquipmentMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(B1900EquipmentMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<B1900EquipmentMaster>> GetAll()
            {
                try
                {
                    var result = await _context.B1900EquipmentMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }

            public async Task<IEnumerable<B1900EquipmentMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.B1900EquipmentMasterList.Where(item => item.Revision == rev).ToListAsync();
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
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, B1900EquipmentMaster t)
            {
                throw new NotImplementedException();
            }
        }
    }
    public class LearjetMasterService
    {
        public class MasterInteriorListService : IMasterBaseService<LearjetInteriorMaster>
        {
            private readonly AppDbContext _context;
            public MasterInteriorListService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(LearjetInteriorMaster t)
            {
                //Append the new Item to the list
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {

                foreach (var item in list)
                {
                    //Check the revision

                    var checkedItem = _context.LearjetInteriorMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        LearjetInteriorMaster i = new LearjetInteriorMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(LearjetInteriorMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<LearjetInteriorMaster>> GetAll()
            {
                try
                {
                    var result = await _context.LearjetInteriorMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }

            public async Task<IEnumerable<LearjetInteriorMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.LearjetInteriorMasterList.Where(item => item.Revision == rev).ToListAsync();
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
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, LearjetInteriorMaster t)
            {
                throw new NotImplementedException();
            }
        }
        public class MasterExteriorListService : IMasterBaseService<LearjetExteriorMaster>
        {
            private readonly AppDbContext _context;
            public MasterExteriorListService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(LearjetExteriorMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.LearjetExteriorMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        LearjetExteriorMaster i = new LearjetExteriorMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(LearjetExteriorMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<LearjetExteriorMaster>> GetAll()
            {
                try
                {
                    var result = await _context.LearjetExteriorMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }

            public async Task<IEnumerable<LearjetExteriorMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.LearjetExteriorMasterList.Where(item => item.Revision == rev).ToListAsync();
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
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, LearjetExteriorMaster t)
            {
                throw new NotImplementedException();
            }
        }

        public class MasterCockpitService : IMasterBaseService<LearjetCockpitMaster>
        {
            private readonly AppDbContext _context;
            public MasterCockpitService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(LearjetCockpitMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.LearjetCockpitMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        LearjetCockpitMaster i = new LearjetCockpitMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(LearjetCockpitMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<LearjetCockpitMaster>> GetAll()
            {
                try
                {
                    var result = await _context.LearjetCockpitMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }

            public async Task<IEnumerable<LearjetCockpitMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.LearjetCockpitMasterList.Where(item => item.Revision == rev).ToListAsync();
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
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, LearjetCockpitMaster t)
            {
                throw new NotImplementedException();
            }
        }

        public class MasterCabinService : IMasterBaseService<LearjetCabinMaster>
        {
            private readonly AppDbContext _context;
            public MasterCabinService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(LearjetCabinMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.LearjetCabinMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        LearjetCabinMaster i = new LearjetCabinMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(LearjetCabinMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<LearjetCabinMaster>> GetAll()
            {
                try
                {
                    var result = await _context.LearjetCabinMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                };
            }

            public async Task<IEnumerable<LearjetCabinMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.LearjetCabinMasterList.Where(i=>i.Revision==rev).ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                };
            }

            public Aircraft GetById(int id)
            {
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, LearjetCabinMaster t)
            {
                throw new NotImplementedException();
            }
        }

        public class MasterFlightFolderService : IMasterBaseService<LearjetFlightFolderMaster>
        {
            private readonly AppDbContext _context;
            public MasterFlightFolderService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(LearjetFlightFolderMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.LearjetFlightFolderMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        LearjetFlightFolderMaster i = new LearjetFlightFolderMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(LearjetFlightFolderMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<LearjetFlightFolderMaster>> GetAll()
            {
                try
                {
                    var result = await _context.LearjetFlightFolderMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }

            public async Task<IEnumerable<LearjetFlightFolderMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.LearjetFlightFolderMasterList.Where(i => i.Revision == rev).ToListAsync();
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
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, LearjetFlightFolderMaster t)
            {
                throw new NotImplementedException();
            }
        }

        public class MasterManualsService : IMasterBaseService<LearjetManualsMaster>
        {
            private readonly AppDbContext _context;
            public MasterManualsService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(LearjetManualsMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.LearjetManualsMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        LearjetManualsMaster i = new LearjetManualsMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(LearjetManualsMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<LearjetManualsMaster>> GetAll()
            {
                try
                {
                    var result = await _context.LearjetManualsMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }

            public async Task<IEnumerable<LearjetManualsMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.LearjetManualsMasterList.Where(i => i.Revision == rev).ToListAsync();
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
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, LearjetManualsMaster t)
            {
                throw new NotImplementedException();
            }
        }
        public class MasterManualsEFBService : IMasterBaseService<LearjetManualsEFBMaster>
        {
            private readonly AppDbContext _context;
            public MasterManualsEFBService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(LearjetManualsEFBMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.LearjetManualsEFBMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        LearjetManualsEFBMaster i = new LearjetManualsEFBMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(LearjetManualsEFBMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<LearjetManualsEFBMaster>> GetAll()
            {
                try
                {
                    var result = await _context.LearjetManualsEFBMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }

            public async Task<IEnumerable<LearjetManualsEFBMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.LearjetManualsEFBMasterList.Where(i => i.Revision == rev).ToListAsync();
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
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, LearjetManualsEFBMaster t)
            {
                throw new NotImplementedException();
            }
        }

        public class MasterOpsDocsService : IMasterBaseService<LearjetOperationDocumentsEquipmentMaster>
        {
            private readonly AppDbContext _context;
            public MasterOpsDocsService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(LearjetOperationDocumentsEquipmentMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.LearjetOperationDocumentsEquipmentMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        LearjetOperationDocumentsEquipmentMaster i = new LearjetOperationDocumentsEquipmentMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(LearjetOperationDocumentsEquipmentMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<LearjetOperationDocumentsEquipmentMaster>> GetAll()
            {
                try
                {
                    var result = await _context.LearjetOperationDocumentsEquipmentMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                };
            }

            public async Task<IEnumerable<LearjetOperationDocumentsEquipmentMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.LearjetOperationDocumentsEquipmentMasterList.Where(i => i.Revision == rev).ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                };
            }

            public Aircraft GetById(int id)
            {
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, LearjetOperationDocumentsEquipmentMaster t)
            {
                throw new NotImplementedException();
            }
        }
        public class MasterAircraftFlipFileService : IMasterBaseService<LearjetAircraftFlipFileMaster>
        {
            private readonly AppDbContext _context;
            public MasterAircraftFlipFileService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(LearjetAircraftFlipFileMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.LearjetAircraftFlipFileMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        LearjetAircraftFlipFileMaster i = new LearjetAircraftFlipFileMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(LearjetAircraftFlipFileMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<LearjetAircraftFlipFileMaster>> GetAll()
            {
                try
                {
                    var result = await _context.LearjetAircraftFlipFileMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                };
            }

            public async Task<IEnumerable<LearjetAircraftFlipFileMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.LearjetAircraftFlipFileMasterList.Where(item=>item.Revision==rev).ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                };
            }

            public Aircraft GetById(int id)
            {
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, LearjetAircraftFlipFileMaster t)
            {
                throw new NotImplementedException();
            }
        }

        public class MasterEquipmentService : IMasterBaseService<LearjetEquipmentMaster>
        {
            private readonly AppDbContext _context;
            public MasterEquipmentService(AppDbContext dbContext)
            {
                _context = dbContext;
            }
            public void Add(LearjetEquipmentMaster t)
            {
                throw new NotImplementedException();
            }

            public void Build(List<string> list, int revision)
            {
                foreach (var item in list)
                {
                    var checkedItem = _context.LearjetEquipmentMasterList.FirstOrDefault(i => i.Descr.Equals(item) && i.Revision == revision);
                    bool exists = checkedItem == null ? false : true;
                    if (!exists)
                    {
                        LearjetEquipmentMaster i = new LearjetEquipmentMaster();
                        i.Descr = item;
                        i.ShortName = "";
                        i.Revision = revision;
                        _context.Add(i);
                    }
                }
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void Delete(LearjetEquipmentMaster t)
            {
                throw new NotImplementedException();
            }

            public bool Exists(string name)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<LearjetEquipmentMaster>> GetAll()
            {
                try
                {
                    var result = await _context.LearjetEquipmentMasterList.ToListAsync();
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }

            public async Task<IEnumerable<LearjetEquipmentMaster>> GetAll(int rev)
            {
                try
                {
                    var result = await _context.LearjetEquipmentMasterList.Where(i=>i.Revision==rev).ToListAsync();
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
                throw new NotImplementedException();
            }

            public Aircraft Update(int id, LearjetEquipmentMaster t)
            {
                throw new NotImplementedException();
            }
        }
    }

}
