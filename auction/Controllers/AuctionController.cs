using Microsoft.AspNetCore.Mvc;

namespace auction.Controllers
{
    /// <summary>
    /// Контроллер для работы с аукционом
    /// </summary>
    [ApiController]
    [Route("api/v1/auction")]
    public class AuctionController : ControllerBase
    {
        /// <summary>
        /// Создание
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task <IActionResult> CreateAuctionsAsync()
        {
            return Ok();
        }
        /// <summary>
        /// Отмена
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public async Task <IActionResult> CancelAuctionsAsync()
        {
            return Ok();
        }
        /// <summary>
        /// Обновление
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task <IActionResult> UpdateAuctionsAsync()
        {
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAuctionsAsync()
        {
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetActionWithDetailsAsync()
        {
            return Ok();
        }
    }
}
