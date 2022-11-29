﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace CMS_Resort.Models
{
    [Table("branch")]
    public partial class Branch
    {
        public Branch()
        {
            Areas = new HashSet<Area>();
            BranchImages = new HashSet<BranchImage>();
            BranchWithRoomtypes = new HashSet<BranchWithRoomtype>();
            Rooms = new HashSet<Room>();
            Supplies = new HashSet<Supply>();
            Supplyings = new HashSet<Supplying>();
        }

        [Key]
        [Column("branch_id")]
        public int BranchId { get; set; }
        [Required]
        [Column("address")]
        [StringLength(200)]
        public string Address { get; set; }
        [Required]
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [Column("telephone")]
        [StringLength(11)]
        public string Telephone { get; set; }
        [Required]
        [Column("province")]
        [StringLength(20)]
        public string Province { get; set; }

        [JsonIgnore]
        [InverseProperty("Brancharea")]
        public virtual ICollection<Area> Areas { get; set; }
        [JsonIgnore]
		[InverseProperty("BranchimgNavigation")]
        public virtual ICollection<BranchImage> BranchImages { get; set; }
        [JsonIgnore]
		[InverseProperty("BedinforBranches")]
        public virtual ICollection<BranchWithRoomtype> BranchWithRoomtypes { get; set; }
        [JsonIgnore]
		[InverseProperty("RoomBranch")]
        public virtual ICollection<Room> Rooms { get; set; }
        [JsonIgnore]
		[InverseProperty("SuppliesBranchNavigation")]
        public virtual ICollection<Supply> Supplies { get; set; }
        [JsonIgnore]
		[InverseProperty("SupplyingBranchNavigation")]
        public virtual ICollection<Supplying> Supplyings { get; set; }
    }
}