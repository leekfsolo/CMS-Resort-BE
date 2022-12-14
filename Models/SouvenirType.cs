// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CMS_Resort.Models
{
    [Table("souvenir_type")]
    public partial class SouvenirType
    {
        [Key]
        [Column("service_id")]
        [StringLength(6)]
        public string ServiceId { get; set; }
        [Key]
        [Column("sou_type")]
        [StringLength(50)]
        public string SouType { get; set; }

        [ForeignKey("ServiceId")]
        [InverseProperty("SouvenirTypes")]
        public virtual Service Service { get; set; }
    }
}