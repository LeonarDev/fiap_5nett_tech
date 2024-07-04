using System.Reflection;
using fiap_5nett_tech.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace fiap_5nett_tech.api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Contact> Contacts { get; set; } = null!;
    public DbSet<Region> Regions { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        /*
        modelBuilder.Entity<Contact>()
            .HasOne(c => c.Id)
            .WithOne(e => e.)
            .HasForeignKey<Region>(r => r.Ddd)
            .IsRequired();*/
    }
}