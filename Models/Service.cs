﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CMS_Resort.Models
{
    [Table("service")]
    public partial class Service
    {
        public Service()
        {
            BusinessPremises = new HashSet<BusinessPremise>();
            SouvenirBrands = new HashSet<SouvenirBrand>();
            SouvenirTypes = new HashSet<SouvenirType>();
            SpaServices = new HashSet<SpaService>();
        }

        [Key]
        [Column("service_id")]
        [StringLength(6)]
        public string ServiceId { get; set; }
        [Column("total_customers")]
        public short TotalCustomers { get; set; }
        [Column("service_type")]
        [StringLength(50)]
        public string ServiceType { get; set; }
        [Required]
        [Column("enterprise_id")]
        [StringLength(6)]
        public string EnterpriseId { get; set; }

        [ForeignKey("EnterpriseId")]
        [InverseProperty("Services")]
        public virtual Enterprise Enterprise { get; set; }
        [InverseProperty("Service")]
        public virtual ICollection<BusinessPremise> BusinessPremises { get; set; }
        [InverseProperty("Service")]
        public virtual ICollection<SouvenirBrand> SouvenirBrands { get; set; }
        [InverseProperty("Service")]
        public virtual ICollection<SouvenirType> SouvenirTypes { get; set; }
        [InverseProperty("Service")]
        public virtual ICollection<SpaService> SpaServices { get; set; }
    }
}