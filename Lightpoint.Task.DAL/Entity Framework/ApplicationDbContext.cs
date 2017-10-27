using Lightpoint.Task.DAL.Entities;
using System;
using System.Data.Entity;


namespace Lightpoint.Task.DAL.Entity_Framework
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shops { get; set; }

        static ApplicationDbContext()
        {
            Database.SetInitializer(new DbInitializer());
        }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public ApplicationDbContext(String connectionStringName)
            :base(connectionStringName)
        {
            Configuration.LazyLoadingEnabled = true;
        }

    }
}
