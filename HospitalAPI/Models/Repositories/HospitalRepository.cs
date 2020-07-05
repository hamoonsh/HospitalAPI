using HospitalAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Repositories
{
    public class HospitalRepository : GeneralMethods, IHospitalRepository
    {
        private HospitalDBContext _db;


        public HospitalRepository(HospitalDBContext db) : base(db)
        {

            _db = db;


        }
        public async Task<IEnumerable<Hospital>> GetHospitalsAsync()
        {
            return await _db.Hospitals.ToListAsync();
        }
    }
}
