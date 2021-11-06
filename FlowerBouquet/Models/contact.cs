using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlowerBouquet.Models
{
    public class contact
    {
        [Key]
        public int contactID { get; set; }
        [Required, Display(Name = "Name")]
        public string Name { get; set; }
        [Required, Display(Name = "Email"), EmailAddress]
        public string SenderEmail { get; set; }
        [Required,Display(Name="Contact us")]
        [StringLength(1000,MinimumLength=3)]
        public string Message { get; set; }
        [Display(Name="Upload Image")]
        public string contactImage { get; set; }

    }
}