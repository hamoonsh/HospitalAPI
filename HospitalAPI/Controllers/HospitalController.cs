using HospitalAPI.Models;
using HospitalAPI.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospitalController : ControllerBase
    {


        private readonly IHospitalRepository _hospitalRepository;
        private readonly IPatientRepository _patientRepository;
        private readonly GeneralMethods _generalMethods;

        public HospitalController(IHospitalRepository hospitalRepository, IPatientRepository patientRepository, GeneralMethods generalMethods)
        {
            _hospitalRepository = hospitalRepository;
            _patientRepository = patientRepository;
            _generalMethods = generalMethods;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Get([FromBody] Enums.Level level)
        {
            return Ok(_hospitalRepository.GetHospitalsWaitTimeByLevel(level));
        }

    }
}
