using CMS_Resort.ExtendModels;
using CMS_Resort.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMS_Resort.Controllers
{
	[Route("api/roomType")]
	[ApiController]
	public class RoomTypeController : ControllerBase
	{
		private readonly RoomTypeProvider roomTypeProvider = new();

		[HttpGet]
		public ActionResult GetAllRoomTypes()
		{
			var data = roomTypeProvider.GetAll();

			if (data == null)
			{
				return NotFound();
			}

			return Ok(new { success = true, data = data.Result });
		}

		[HttpGet("{id}")]
		public ActionResult GetRoomTypeById(int id)
		{
			var data = roomTypeProvider.GetById(id);

			if (data == null)
			{
				return NotFound();
			}

			return Ok(new { success = true, data = data.Result });
		}

		[HttpPost]
		public async Task<ActionResult> AddRoomType(AddedRoomType data)
		{
			var id = await roomTypeProvider.Create(data);

			return CreatedAtAction(nameof(AddRoomType), new { id }, new { Success = true, Data = data });
		}
	}
}
