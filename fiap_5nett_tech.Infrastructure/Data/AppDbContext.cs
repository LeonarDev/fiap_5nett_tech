using fiap_5nett_tech.Domain.Entities;
using fiap_5nett_tech.Infrastructure.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace fiap_5nett_tech.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Region> Regions { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new ContactMapping());
        modelBuilder.ApplyConfiguration(new RegionMapping());

    }
}