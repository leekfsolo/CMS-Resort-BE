// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CMS_Resort.Models
{
    [Table("area")]
    public partial class Area
    {
        [Key]
        [Column("brancharea_id")]
        public int BranchareaId { get; set; }
        [Key]
        [Column("area_name")]
        [StringLength(100)]
        public string AreaName { get; set; }

        [ForeignKey("BranchareaId")]
        [InverseProperty("Areas")]
        public virtual Branch Brancharea { get; set; }
    }
}