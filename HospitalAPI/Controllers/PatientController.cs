using HospitalAPI.Models.Entities;
using HospitalAPI.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HospitalAPI.Controllers
{
    [ApiVersion("1.0")]
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

        /// <summary>
        /// RegPatient
        /// </summary>
        /// <param name="patient">patient model</param>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> RegPatient([FromBody] Patient patient)
        {
            patient.RegTime = DateTime.Now;
            // TODO
            // Get additional data like ensurance number , personal info , etc ...
            // if (patient.MobileNumber.IsVerified)
            // {
            if (!ModelState.IsValid)
                return BadRequest();

            if (await _generalMethods.AddAsyncOrUpdate(patient) && await _generalMethods.SaveChangesAsync())
                return Ok();
            return StatusCode(500);
            // }
        }

        [HttpGet]
        [Route("Truncate")]
        public IActionResult Truncate()
        {
            try
            {
                _patientRepository.Truncate();
                return Ok();
            }
            catch (Exception er)
            {
                string m = er.Message;
                return StatusCode(500);
            }
        }
    }
}
