using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlowerBouquet.Models
{
    public class team
    {
        [Key]
        public int teamID { get; set; }
        [Required]
        public string adminName { get; set; }
        [Required]
        public string studentid { get; set; }
       
        public string adminimage { get; set; }
    }
}