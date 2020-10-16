﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class ActivationCode
    {
        public string Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public virtual OrderDetail OrderDetails { get; set; }
        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
