using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerBouquet.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int categoryId { get; set; }
        [Required(ErrorMessage = "Category Name Required")]
        [StringLength(100, MinimumLength = 3)]
        public string categoryName { get; set; }
        public bool isActive { get; set; }
        public bool isDelete { get; set; }
        public virtual ICollection<product> products { get; set; }

    }
}