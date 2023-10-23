using Admin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Admin.Data
{
    public class AdminDbContext : DbContext
    {
        public AdminDbContext(DbContextOptions<AdminDbContext> options) : base(options)
        {
            
        }

        public DbSet<AdminModel> Admins { get; set; }
    }
}
