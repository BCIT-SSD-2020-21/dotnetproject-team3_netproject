﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuys.Models
{
    public class ShoppingCart : BaseEntity
    {
        public string ShippingAddress { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public int Status { get; private set; }
        //public string UserId { get; private set; }
        public virtual ICollection<CartProduct> CartProducts { get; set; }

        //public ShoppingCart(string userid)
        //{
        //    UserId = userid;
        //}
        public ShoppingCart()
        {

        }
    }
}
