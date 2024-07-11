using System.Reflection;
using fiap_5nett_tech.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace fiap_5nett_tech.api.Data;

public class AppDbContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; } 
    public DbSet<Region> Regions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Configure the Contact entity if necessary
    }
}