using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FlowerBouquet.Models
{
    public class Cart
    {
        [Key]

        public int cartID { get; set; }
        public int productId { get; set; }
        [ForeignKey("productId")]
        public virtual product products { get; set; }
        [Range(typeof(int), "1", "500", ErrorMessage = "Invalid Quantity")]
        public int quantity { get; set; }
        [Required(ErrorMessage = "Please give a valid price")]
        public int price { get; set; }
        public DateTime createdDate { get; set; }
        public virtual ICollection<product> productcollection { get; set; }


    }
}