using HospitalAPI.Models;
using HospitalAPI.Models.Repositories;
using HospitalAPI.Models.RequestModels;
using HospitalAPI.Models.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Get([FromBody] GetHospitalReq req)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            return Ok(new GetHospitalRes { Hospitals = await _hospitalRepository.GetHospitalsWaitTimeByLevel(req.Level) });
        }
    }
}