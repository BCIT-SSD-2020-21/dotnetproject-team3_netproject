﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuys.Models
{
    public class ShoppingCart : BaseEntity
    {
        public DateTime CreatedOn { get; private set; }
        public int Status { get; private set; }

        public virtual ICollection<CartProduct> CartProducts { get; set; }
        public virtual CheckoutInfo CheckoutInfo { get; set; }
    }
}

