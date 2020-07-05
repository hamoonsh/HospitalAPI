using HospitalAPI.Models.Entities;
using HospitalAPI.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IHospitalRepository _hospitalRepository;
        private readonly IPatientRepository _patientRepository;
        private readonly GeneralMethods _generalMethods;

        public WeatherForecastController(IHospitalRepository hospitalRepository, IPatientRepository patientRepository, GeneralMethods generalMethods)
        {
            _hospitalRepository = hospitalRepository;
            _patientRepository = patientRepository;
            _generalMethods = generalMethods;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_hospitalRepository.GetHospitalsWaitTimeByLevel(Models.Enums.Level.One));
        }

        [HttpPost]
        [Route("RegPatient")]
        public async Task<IActionResult> RegPatient([FromBody] Patient patient)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            if (_generalMethods.AddOrUpdate(patient) && _generalMethods.SaveChanges())
                return Ok();
            return StatusCode(500);
        }
    }
}