using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PracticaMVC.Models
{
    public class PracticaMVCContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PracticaMVCContext() : base("name=PracticaMVCContext")
        {
        }

        //No permite el eliminado en cascada
        //-------------------
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        //
        public System.Data.Entity.DbSet<PracticaMVC.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<PracticaMVC.Models.DocumentType> DocumentTypes { get; set; }

        public System.Data.Entity.DbSet<PracticaMVC.Models.Supplier> Suppliers { get; set; }

        public System.Data.Entity.DbSet<PracticaMVC.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<PracticaMVC.Models.SupplierProduct> SupplierProducts { get; set; }

        public System.Data.Entity.DbSet<PracticaMVC.Models.Employee> Employees { get; set; }
    
    }
}
