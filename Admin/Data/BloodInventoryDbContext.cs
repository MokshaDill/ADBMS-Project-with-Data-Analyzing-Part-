using Microsoft.EntityFrameworkCore;

namespace Admin.Data
{
    public class BloodinventoryDbContext : DbContext
    {
        public BloodinventoryDbContext(DbContextOptions<BloodinventoryDbContext> options) : base(options)
        {
        }

        public DbSet<BloodStorage> BloodStorages { get; set; }
    }
}
