using Admin.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

public class MessageDbContext : DbContext
{
    public DbSet<Admin.Models.DonorModel> Donors { get; set; }
    public DbSet<Admin.Models.Message> Messages { get; set; }

    public MessageDbContext(DbContextOptions<MessageDbContext> options) : base(options)
    {
    }

    public MessageDbContext()
    {
    }
}
