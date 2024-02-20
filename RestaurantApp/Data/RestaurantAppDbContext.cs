namespace RestaurantApp.Data;

using Microsoft.EntityFrameworkCore;
using RestaurantApp.Entities;

public class RestaurantAppDbContext : DbContext
{
    public DbSet<Customers> Employees => Set<Customers>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("StoreAppDb");
    }
}
