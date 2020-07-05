using HospitalAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalAPI.Models.Repositories
{
    public class GeneralMethods
    {
        private HospitalDBContext _db;



        public GeneralMethods(HospitalDBContext db)
        {
            _db = db;
        }

        public void AddOrUpdate(object entity)
        {
            var state = _db.Entry(entity).State;

            switch (state)
            {
                case EntityState.Detached:
                    _db.Add(entity);
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
        }

        public void Delete(object entity)
        {
            _db.Remove(entity);
        }

    }
}
