using HospitalAPI.Models.Entities;
using HospitalAPI.Models.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Repositories
{
    public interface IHospitalRepository
    {
        Task<IEnumerable<Hospital>> GetHospitalsAsync();

        Task<List<GetHospitalsWaitTimeByLevelResponse>> GetHospitalsWaitTimeByLevel(Enums.Level level);
    }
}