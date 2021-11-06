using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowerBouquet.Models
{
    public class AdminOrder
    {
        public IEnumerable<Cart> cartviewmodel { get; set; }
        public Order orders { get; set; }
    }
}