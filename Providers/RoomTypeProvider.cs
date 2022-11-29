using CMS_Resort.ExtendModels;
using CMS_Resort.Models;
using Microsoft.EntityFrameworkCore;

namespace CMS_Resort.Providers
{
	public class RoomTypeProvider : BaseProvider
	{
		public async Task<List<Roomtype>> GetAll()
		{
			return await db.Roomtypes.Include(roomtype => roomtype.BedInformations).ToListAsync();
		}

		public async Task<Roomtype> GetById(int id)
		{
			return await db.Roomtypes.Where(room => room.RoomtypeId == id).FirstAsync();
		}

		public async Task<int> Create(AddedRoomType data)
		{
			var roomType = new Roomtype
			{ 
				RoomtypeArea=data.RoomtypeArea, 
				RoomtypeName=data.RoomtypeName, 
				RoomtypeNoGuests=data.RoomtypeNoGuests,
				RoomtypeDescription=data.RoomtypeDescription
			};
			db.Roomtypes.Add(roomType);
			await db.SaveChangesAsync();

			var addedRoomType = await db.Roomtypes.Where(roomtype => roomtype.RoomtypeName.Equals(roomType.RoomtypeName)).FirstAsync();

			var bedInfo = new BedInformation
			{
				BedinforNoBeds=data.BedinforNoBeds,
				BedinforSize=data.BedinforSize,
				BedinforId=addedRoomType.RoomtypeId,
			};

			db.BedInformations.Add(bedInfo);
			await db.SaveChangesAsync();

			return roomType.RoomtypeId;
		}
	}
}
