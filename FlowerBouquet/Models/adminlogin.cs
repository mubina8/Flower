using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlowerBouquet.Models
{
    public class adminlogin
    {
        [Key]
        public int adminID { get; set; }
        [Required(ErrorMessage = "username Name is required")]
        [StringLength(100, MinimumLength = 3)]
        public string username { get; set; }
        [Required(ErrorMessage = "Please Enter a Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}