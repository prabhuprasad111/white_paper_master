using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using white_paper_master.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using white_paper_master.Interface.Master;

namespace white_paper_master.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[AllowAnonymo us]
    [Authorize]
    public class MasterController : ControllerBase
    {
        private readonly IMasterRepository _masterRepository;
        
        public MasterController(IMasterRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }
        
        [HttpGet("district")]
        public async Task<ActionResult<IEnumerable<object>>> GetDistricts()
        {
            var districts = await _masterRepository.GetDistrictsAsync();
            return Ok(districts);
        }

        [HttpGet("policestations")]
        public async Task<ActionResult<IEnumerable<object>>> GetPoliceStations([FromQuery] int district_cd)
        {
            var stations = await _masterRepository.GetPoliceStationsAsync(district_cd);
            return Ok(stations);
        }
    }
}


