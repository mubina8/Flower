using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerBouquet.Models
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(100, MinimumLength = 3)]
        public string F_name { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(100, MinimumLength = 3)]
        public string L_name { get; set; }
        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }
        [Required(ErrorMessage = "Please Enter a Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}