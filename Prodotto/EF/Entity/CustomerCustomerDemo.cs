﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Prodotto.EF.Entity
{
    [Keyless]
    public partial class CustomerCustomerDemo
    {
        [Required]
        [Column("CustomerID")]
        [StringLength(5)]
        public string CustomerId { get; set; }
        [Required]
        [Column("CustomerTypeID")]
        [StringLength(10)]
        public string CustomerTypeId { get; set; }
    }
}