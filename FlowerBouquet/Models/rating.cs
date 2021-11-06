using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerBouquet.Models
{
    public class rating
    {
        [Key]
        public int ratingID { get; set; }
   
        public int productId { get; set; }
        [ForeignKey("productId")]
        public virtual product products { get; set; }

        public int ratings { get; set; }


    }
}