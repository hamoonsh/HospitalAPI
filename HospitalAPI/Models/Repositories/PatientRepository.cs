using HospitalAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private HospitalDBContext _db;

        public PatientRepository(HospitalDBContext db)
        {
            _db = db;
        }
    }
}