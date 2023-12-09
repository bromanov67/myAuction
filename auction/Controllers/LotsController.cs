using Microsoft.AspNetCore.Mvc;

namespace auction.Controllers
{
    /// <summary>
    /// Controller for lots
    /// </summary>
    [ApiController]
    [Route("api/v1/auction/lots")]
    public class LotsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateLotAsync()
        {
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> CancelLotAsync()
        {
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateLotAsync()
        {
            return Ok();
        }
    
        [HttpGet]
        public async Task<IActionResult> GetLotsByAuctionIdAsync()
        {
            return Ok();
        }
}
}
