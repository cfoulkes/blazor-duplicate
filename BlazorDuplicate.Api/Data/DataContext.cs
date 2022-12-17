using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorDuplicate.Api.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    // public DbSet<Cart> Carts => Set<Cart>();
    // public DbSet<CartItem> CartItems => Set<CartItem>();
    // public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();
    // public DbSet<Product> Products => Set<Product>();
    // public DbSet<User> Users => Set<User>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}
