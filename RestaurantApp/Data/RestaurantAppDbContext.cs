namespace RestaurantApp.Data;

using Microsoft.EntityFrameworkCore;
using RestaurantApp.Entities;
using RestaurantApp.Repositories;
using System.Collections.Generic;
using System.Diagnostics;

public class RestaurantAppDbContext : DbContext
{
    public DbSet<Food> Employees => Set<Food>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("StoreAppDb");
    }
}
