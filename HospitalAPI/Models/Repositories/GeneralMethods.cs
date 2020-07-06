using HospitalAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Repositories
{
    public class GeneralMethods
    {
        private HospitalDBContext _db;

        public GeneralMethods(HospitalDBContext db)
        {
            _db = db;
        }

        public async Task<bool> AddAsyncOrUpdate(object entity)
        {
            try
            {
                var state = _db.Entry(entity).State;

                switch (state)
                {
                    case EntityState.Detached:
                        await _db.AddAsync(entity);
                        break;

                    case EntityState.Modified:
                        _db.Update(entity);
                        break;

                    case EntityState.Added:
                    case EntityState.Deleted:
                    case EntityState.Unchanged:
                        // do nothing
                        break;
                }
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public async Task<bool> SaveChangesAsync()
        {
            try
            {
                if (await _db.SaveChangesAsync() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool Delete(object entity)
        {
            try
            {
                _db.Remove(entity);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
