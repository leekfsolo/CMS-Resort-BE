using CMS_Resort.ExtendModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMS_Resort.Controllers
{
	[EnableCors("MyPolicy")]
	[Route("api/auth")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IConfiguration _configuration;

		public AuthController(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		[HttpPost]
		public ActionResult Authenticate([FromBody] UserLogin user)
		{
			var username = _configuration.GetValue<string>("credential:username").ToString();
			var password = _configuration.GetValue<string>("credential:password").ToString();

			if (username == user.Username && password == user.Password)
			{
				return Ok(new { Success = true, username });
			}

			return BadRequest();

		}
	}
}
