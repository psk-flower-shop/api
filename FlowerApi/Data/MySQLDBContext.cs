using FlowerApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlowerApi.Data;
public class MySQLDBContext : DbContext
{
    public DbSet<Cart> Cart { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<User> User { get; set; }
    public MySQLDBContext(DbContextOptions<MySQLDBContext> options) : base(options) { }
}