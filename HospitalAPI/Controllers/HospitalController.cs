using HospitalAPI.Models;
using HospitalAPI.Models.Repositories;
using HospitalAPI.Models.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HospitalAPI.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("[controller]")]
    public class HospitalController : ControllerBase
    {
        private readonly IHospitalRepository _hospitalRepository;


        public HospitalController(IHospitalRepository hospitalRepository)
        {
            _hospitalRepository = hospitalRepository;

        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get([FromQuery] Enums.Level level)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            return Ok(new GetHospitalRes { Hospitals = await _hospitalRepository.GetHospitalsWaitTimeByLevel(level) });
        }
    }
}
