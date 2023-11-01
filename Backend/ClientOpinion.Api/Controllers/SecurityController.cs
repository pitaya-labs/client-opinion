using Microsoft.AspNetCore.Mvc;

namespace Backend.Api.Controllers
{
    [Route("api/security")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        public IActionResult RegisterUser()
        {
            return Ok();
        }
        
    }
}

