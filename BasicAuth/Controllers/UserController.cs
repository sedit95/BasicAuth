using BasicAuth.Models;
using BasicAuth.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasicAuth.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("auth")]
        public ActionResult Authenticate([FromBody] AuthModel authModel)
        {
            var user = _userService.Authenticate(authModel.UserName, authModel.Password);
            if (user == null) return BadRequest(new { message = "Kullanıcı adı yada şifre yanlış" });
            return Ok(user);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

    }
}
