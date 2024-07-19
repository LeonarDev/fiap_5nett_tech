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
        modelBuilder.ApplyConfiguration(new ContactMapping());
        modelBuilder.ApplyConfiguration(new RegionMapping());

        modelBuilder.Entity<Contact>()
            .HasOne<Region>(c => c.Ddd)
            .WithMany(r => r.Contacts)
            .HasForeignKey("DDD")
            .HasConstraintName("FK_CONTACT_REGION");
        
        base.OnModelCreating(modelBuilder);
    }   
}