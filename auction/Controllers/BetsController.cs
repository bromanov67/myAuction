using Microsoft.AspNetCore.Mvc;

namespace auction.Controllers
{
    /// <summary>
    /// Controller for bets
    /// </summary>
    [ApiController]
    [Route("api/v1/auction/lots/bets")]
    public class BetsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> DoBetAsync()
        {
            return Ok();
        }
    }
}
