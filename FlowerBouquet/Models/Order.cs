using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerBouquet.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string address { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required]
        public string Contact { get; set; }
        [Display(Name = "Date")]
        public DateTime orderdate { get; set; }
        

    }
}