using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowerBouquet.Models
{
    public class OrderViewModel
    {
        public IEnumerable<Order> orderviewmodel { get; set; }
        public IEnumerable<Cart> cartviewmodel { get; set; }

    }
}