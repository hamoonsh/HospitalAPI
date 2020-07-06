using HospitalAPI.Models.Entities;
using HospitalAPI.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HospitalAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {



        private readonly IPatientRepository _patientRepository;
        private readonly GeneralMethods _generalMethods;

        public PatientController(IPatientRepository patientRepository, GeneralMethods generalMethods)
        {

            _patientRepository = patientRepository;
            _generalMethods = generalMethods;
        }
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> RegPatient([FromBody] Patient patient)
        {
            // TODO
            // if (patient.MobileNumber.IsVerified)
            // {

            if (!ModelState.IsValid)
                return BadRequest();

            if (await _generalMethods.AddAsyncOrUpdate(patient) && await _generalMethods.SaveChangesAsync())
                return Ok();
            return StatusCode(500);
            // }
        }
    }
}
