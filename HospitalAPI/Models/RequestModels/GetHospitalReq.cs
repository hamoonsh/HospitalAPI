using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.RequestModels
{
    public class GetHospitalReq
    {
        [Required]
        public Enums.Level Level { get; set; }
    }
}