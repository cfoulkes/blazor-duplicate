using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDuplicate.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorDuplicate.Api.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<ClientType> ClientTypes => Set<ClientType>();
    public DbSet<Country> Countries => Set<Country>();
    public DbSet<ProvinceState> ProvinceStates => Set<ProvinceState>();

    public DbSet<Client> Clients => Set<Client>();
    public DbSet<ClientPerson> ClientPersons => Set<ClientPerson>();

    // public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();
    // public DbSet<Product> Products => Set<Product>();
    // public DbSet<User> Users => Set<User>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder
            .Entity<Country>()
            .HasData(
                new Country
                {
                    Id = 1,
                    Code = "CA",
                    Description = "Canada",
                },
                new Country
                {
                    Id = 2,
                    Code = "US",
                    Description = "United States",
                }
            );

        modelBuilder
            .Entity<ClientType>()
            .HasData(
                new ClientType
                {
                    Id = 1,
                    Code = "P",
                    Description = "Person",
                },
                new ClientType
                {
                    Id = 2,
                    Code = "O",
                    Description = "Other",
                }
            );

        modelBuilder
            .Entity<ProvinceState>()
            .HasData(
                new ProvinceState
                {
                    Id = 1,
                    Code = "MB",
                    Description = "Manitoba",
                    CountryId = 1
                },
                new ProvinceState
                {
                    Id = 2,
                    Code = "ON",
                    Description = "Ontario",
                    CountryId = 1
                },
                new ProvinceState
                {
                    Id = 3,
                    Code = "ME",
                    Description = "Maine",
                    CountryId = 2
                }
            );
    }
}
