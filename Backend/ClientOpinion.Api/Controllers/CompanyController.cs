using Microsoft.AspNetCore.Mvc;

namespace Backend.Api.Controllers
{
    [Route("api/company")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        [HttpGet("list")]
        public IActionResult List()
        {
            return Ok("List of companies");
        }
    }
}
