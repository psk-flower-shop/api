using FlowerApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlowerApi.Data
{
    public class FlowersContext : DbContext
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }


        public string DbPath { get; }

        public FlowersContext()
        {
            DbPath = "flowers.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}