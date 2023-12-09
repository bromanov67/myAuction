using Microsoft.AspNetCore.Mvc;

namespace auction.Controllers
{
    /// <summary>
    /// Controller for Users
    /// </summary>

    [ApiController]
    [Route("api/v1/users")]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Авторизовать пользователя
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> AuthUserAsync()
        {
            return Ok();
        }

    }
}