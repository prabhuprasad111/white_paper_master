using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using white_paper_master.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using white_paper_master.Interface.Master;

namespace white_paper_master.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MasterController : ControllerBase
    {
        private readonly IMasterRepository _masterRepository;

        // Inject IMasterRepository via constructor
        public MasterController(IMasterRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }

        // GET: api/Master/district
        [HttpGet("district")]
        public async Task<ActionResult<IEnumerable<object>>> GetDistricts()
        {
            var districts = await _masterRepository.GetDistrictsAsync();
            return Ok(districts);
        }

        // GET: api/Master/policestations
        [HttpGet("policestations")]
        public async Task<ActionResult<IEnumerable<object>>> GetPoliceStations([FromQuery] int district_cd)
        {
            var stations = await _masterRepository.GetPoliceStationsAsync(district_cd);
            return Ok(stations);
        }
    }
}


