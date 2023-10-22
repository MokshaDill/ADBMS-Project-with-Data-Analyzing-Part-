using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Admin.Data
{
    public class CampstatusDbContext : IdentityDbContext
    {
        public CampstatusDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}