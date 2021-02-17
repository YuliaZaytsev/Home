using HomeTaskApi.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HomeTaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CumulativeJobInfoController : ControllerBase
    {
        private ICumulativeJobInfoRepository _cumulativeJobInfoRepository;

        public CumulativeJobInfoController(ICumulativeJobInfoRepository cumulativeJobInfoRepository)
        {
            _cumulativeJobInfoRepository = cumulativeJobInfoRepository;
        }

        // GET api/[controller]
        [HttpGet]
        public async Task<IActionResult> GetCumulativeJobInfoByDates(DateTime from, DateTime to)
        {
            try
            {
                var jobsInfo = await _cumulativeJobInfoRepository.GetCumulativeJobInfoByDates(from, to);
                return Ok(jobsInfo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }            
        }
    }
}
