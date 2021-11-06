using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FlowerBouquet.Data
{
    public class FlowerBouquetContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FlowerBouquetContext() : base("name=FlowerBouquetContext")
        {
        }

        public System.Data.Entity.DbSet<FlowerBouquet.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<FlowerBouquet.Models.product> products { get; set; }



        //public System.Data.Entity.DbSet<FlowerBouquet.Models.Review> Reviews { get; set; }

        public System.Data.Entity.DbSet<FlowerBouquet.Models.Cart> Carts { get; set; }

      

        public System.Data.Entity.DbSet<FlowerBouquet.Models.Member> Members { get; set; }

        public System.Data.Entity.DbSet<FlowerBouquet.Models.adminlogin> adminlogins { get; set; }

        public System.Data.Entity.DbSet<FlowerBouquet.Models.rating> ratings { get; set; }

        public System.Data.Entity.DbSet<FlowerBouquet.Models.contact> contacts { get; set; }

        public System.Data.Entity.DbSet<FlowerBouquet.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<FlowerBouquet.Models.team> teams { get; set; }



        //public System.Data.Entity.DbSet<FlowerBouquet.Models.Review> Reviews { get; set; }
    }
}
