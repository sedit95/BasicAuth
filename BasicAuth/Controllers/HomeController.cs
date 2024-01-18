using Microsoft.AspNetCore.Mvc;

namespace BasicAuth.Controllers
{
    [Route("api/[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {

            return Ok();
        }
    }
}
    