﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CMS_Resort.Models
{
    [Table("invoice")]
    public partial class Invoice
    {
        [Key]
        [Column("invoice_id")]
        [StringLength(16)]
        public string InvoiceId { get; set; }
        [Column("checkin_time")]
        public TimeOnly? CheckinTime { get; set; }
        [Column("checkout_time")]
        public TimeOnly? CheckoutTime { get; set; }
        [Required]
        [Column("booking_id")]
        [StringLength(16)]
        public string BookingId { get; set; }

        [ForeignKey("BookingId")]
        [InverseProperty("Invoices")]
        public virtual BookingReservation Booking { get; set; }
    }
}