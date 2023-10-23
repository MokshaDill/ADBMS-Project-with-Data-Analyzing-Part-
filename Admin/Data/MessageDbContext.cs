using Admin.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

public class MessageDbContext : DbContext
{
    
        public MessageDbContext(DbContextOptions<MessageDbContext> options) : base(options)
        {

        }

        public DbSet<Message> Message { get; set; }
    
}
