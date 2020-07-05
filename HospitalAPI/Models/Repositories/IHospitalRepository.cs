using HospitalAPI.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Repositories
{
    public interface IHospitalRepository
    {
        Task<IEnumerable<Hospital>> GetHospitalsAsync();
    }
}
