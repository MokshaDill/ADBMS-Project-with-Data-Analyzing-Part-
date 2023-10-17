using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Blood_Donor_Portal.Models;

namespace Blood_Donor_Portal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Blood_Donor_Portal.Models.User>? User { get; set; }
        public DbSet<Blood_Donor_Portal.Models.BloodCamp>? BloodCamp { get; set; }
    }
}