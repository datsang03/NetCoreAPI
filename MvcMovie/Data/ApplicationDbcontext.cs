using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set; } 
        public DbSet<Employee> Employees { get; set; } 
         public DbSet<HeThongPhanPhoi> HeThongPhanPhoi { get; set; } 
         public DbSet<DaiLy> DaiLy { get; set; }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<HeThongPhanPhoi>()
            .HasMany(e=>e.DaiLy)
            .WithOne(p=>p.HTPP)
            .HasForeignKey(c=>c.MaHTPP)
            .OnDelete(DeleteBehavior.Restrict);
    }
        }
    }
