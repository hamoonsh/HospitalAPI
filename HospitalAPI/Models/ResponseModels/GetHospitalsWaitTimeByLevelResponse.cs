using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.ResponseModels
{
    public class GetHospitalsWaitTimeByLevelResponse
    {
        public int HospitalID { get; set; }
        public string Name { get; set; }
        public int WaitingTime { get; set; }
    }
}