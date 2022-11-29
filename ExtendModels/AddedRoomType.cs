using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CMS_Resort.ExtendModels
{
	public class AddedRoomType
	{
		[Required]
		[Column("roomtype_name")]
		[StringLength(50)]
		public string RoomtypeName { get; set; }
		[Required]
		[Column("roomtype_area")]
		[StringLength(10)]
		public string RoomtypeArea { get; set; }
		[Required]
		[Column("roomtype_description")]
		[StringLength(300)]
		public string RoomtypeDescription { get; set; }
		[Column("roomtype_no_guests")]
		public short RoomtypeNoGuests { get; set; }
		[Column("bedinfor_size")]
		[Precision(2, 1)]
		public decimal BedinforSize { get; set; }
		[Column("bedinfor_no_beds")]
		public short BedinforNoBeds { get; set; }
	}
}
