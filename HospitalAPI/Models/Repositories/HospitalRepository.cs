using HospitalAPI.Models.Entities;
using HospitalAPI.Models.ResponseModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Repositories
{
    public class HospitalRepository : IHospitalRepository
    {
        private HospitalDBContext _db;

        public HospitalRepository(HospitalDBContext db)
        {
            _db = db;
        }

        /// <summary>
        /// GetHospitalsAsync
        /// </summary>
        /// <returns>IEnumerable<Hospital></returns>
        public async Task<IEnumerable<Hospital>> GetHospitalsAsync()
        {
            return await _db.Hospitals.ToListAsync();
        }

        /// <summary>
        /// GetHospitalsWaitTimeByLevel
        /// </summary>
        /// <param name="level">defines sickness of patient</param>
        /// <returns>IEnumerable<GetHospitalsWaitTimeByLevelResponse></returns>
        public async Task<List<GetHospitalsWaitTimeByLevelResponse>> GetHospitalsWaitTimeByLevel(Enums.Level level)
        {
            var response = new List<GetHospitalsWaitTimeByLevelResponse>();
            IEnumerable<Hospital> hospitals = _db.Hospitals;
            // if hospital has more than one doctor calculation would be different
            foreach (Hospital h in hospitals)
            {
                int time = 0;
                IEnumerable<Patient> patients = _db.Patients.Where(p => p.HospitalID == h.HospitalID);
                foreach (Patient p in patients)
                {
                    if (level >= p.Level)
                    {
                        switch (p.Level)
                        {
                            case Enums.Level.Zero:
                                time += h.levelZeroVisitingTime;
                                break;

                            case Enums.Level.One:
                                time += h.levelOneVisitingTime;
                                break;

                            case Enums.Level.Two:
                                time += h.levelTwoVisitingTime;
                                break;

                            case Enums.Level.Three:
                                time += h.levelThreeVisitingTime;
                                break;

                            case Enums.Level.Four:
                                time += h.levelFourVisitingTime;
                                break;
                        }
                    }
                }
                Doctor doctor = _db.Doctors.Where(p => p.DoctorID == (_db.HospitalDoctors.Where(x => x.HospitalID == h.HospitalID).FirstOrDefault().DoctorID)).FirstOrDefault();
                response.Add(new GetHospitalsWaitTimeByLevelResponse
                {
                    HospitalID = h.HospitalID,
                    Name = h.Name,
                    WaitingTime = time,
                    Doctor = doctor.Name + " " + doctor.Family
                });
            }
            return response;
        }
    }
}