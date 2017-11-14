using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Brandingv1._0.Models
{
    public class Brandingv10Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Brandingv10Context() : base("name=Brandingv10Context")
        {
        }

        public System.Data.Entity.DbSet<Brandingv1._0.Models.estudios> estudios { get; set; }

        public System.Data.Entity.DbSet<Brandingv1._0.Models.hobbies> hobbies { get; set; }

        public System.Data.Entity.DbSet<Brandingv1._0.Models.hojavida> hojavidas { get; set; }

        public System.Data.Entity.DbSet<Brandingv1._0.Models.referencias> referencias { get; set; }
    
    }
}
