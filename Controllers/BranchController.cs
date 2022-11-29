using CMS_Resort.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System.Data;

namespace CMS_Resort.Controllers
{
	[Route("api/branch")]
	[ApiController]
	public class BranchController : ControllerBase
	{
		private readonly BranchProvider branchProvider = new();

		[HttpGet]
		public ActionResult GetAllBranches()
		{
			var data = branchProvider.GetAll();

			if (data == null)
			{
				return NotFound();
			}

			return Ok(new { success = true, data = data.Result });
		}

		/*
		[HttpGet("getBranchesByFunction")]
		public ActionResult GetBranchesByFunction(int id, int year)
		{
			NpgsqlConnection conn = new("Host = localhost; Database = Resort Management; Username = sManager; Password = admin;");
			NpgsqlCommand cmd = new($"SELECT * FROM ThongKeLuotKhach(SMALLINT '{id}', SMALLINT '{year}')", conn);
			conn.Open();
			object cursorVal = cmd.ExecuteScalar();
			DataSet ds = branchProvider.GetByFunction(conn, cursorVal);
			cmd.Dispose();
			conn.Close();

			return Ok(new { Success = true, Data = ds });
		}
		*/
	}
}
