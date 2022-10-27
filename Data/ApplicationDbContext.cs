using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using provinceCity.Models;

namespace provinceCity.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {

        base.OnModelCreating(builder);


    builder.Entity<City>().ToTable("City");
    builder.Entity<Province>().ToTable("Province");
    builder.Seed();
    }
    public DbSet<City>Cities { get; set; }
    public DbSet<Province> Provinces{ get; set; }
}
