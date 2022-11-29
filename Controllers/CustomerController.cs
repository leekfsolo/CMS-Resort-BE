using CMS_Resort.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace CMS_Resort.Controllers
{
	[Route("api/customer")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly CustomerProvider customerProvider = new();

		[HttpGet]
		public ActionResult GetAllCustomers()
		{
			var data = customerProvider.GetAll();

			if (data == null)
			{
				return NotFound();
			}

			return Ok(new {success = true, data = data.Result});
		}

		[HttpGet("{id}")]
		public ActionResult GetCustomerById(string id)
		{
			var data = customerProvider.GetById(id);

			if (data == null)
			{
				return NotFound();
			}

			return Ok(new { success = true, data = data.Result });
		}

		[HttpGet("getFilterCustomers")]
		public ActionResult GetCustomersByFullname(string? fullname)
		{

			if (fullname == null)
			{
				var tmp = customerProvider.GetAll();

				return Ok(new { success = true, data = tmp.Result });
			}

			var data = customerProvider.GetByName(fullname);

			return Ok(new { success = true, data = data.Result });
		}
	}
}
