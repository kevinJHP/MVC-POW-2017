using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace _20171112.Models
{
 
    public class _20171112Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public _20171112Context() : base("name=_20171112Context")
        {
        }

        public System.Data.Entity.DbSet<_20171112.Models.Albums> Albums { get; set; }

        public System.Data.Entity.DbSet<_20171112.Models.Artists> Artists { get; set; }

        public System.Data.Entity.DbSet<_20171112.Models.Customers> Customers { get; set; }

        public System.Data.Entity.DbSet<_20171112.Models.CustomerTypes> CustomerTypes { get; set; }

        public System.Data.Entity.DbSet<_20171112.Models.Genres> Genres { get; set; }

        public System.Data.Entity.DbSet<_20171112.Models.OrderDetails> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<_20171112.Models.Orders> Orders { get; set; }

        public System.Data.Entity.DbSet<_20171112.Models.Ubigeos> Ubigeos { get; set; }
        
        //No permite el eliminado en cascada
        //-------------------
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        //

    }
}
