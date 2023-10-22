using Admin.Models;
using Microsoft.EntityFrameworkCore;

namespace Admin.Data
{
    public class AdminDbContext : DbContext
    {
        public AdminDbContext(DbContextOptions<AdminDbContext> options) : base(options)
        {
        }

        public DbSet<AdminModel> Admins { get; set; }
        // Define DbSet properties for other entities as needed

        // Add configuration for tables and relationships using the Fluent API or data annotations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminModel>()
                .HasKey(admin => admin.AdminId);
        }
    }
}
