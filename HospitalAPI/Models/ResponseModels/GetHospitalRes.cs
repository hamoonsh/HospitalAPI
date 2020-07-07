using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.ResponseModels
{
    public class GetHospitalRes
    {
        public List<GetHospitalsWaitTimeByLevelResponse> Hospitals { get; set; }
    }
}