using Microsoft.EntityFrameworkCore;

namespace RazorPagesShoutBox.Data
{
    public class ShoutBoxContext : DbContext
    {
        public ShoutBoxContext(DbContextOptions<ShoutBoxContext> options) :base(options)
        { }

        public DbSet<ShoutBoxItem> ShoutBoxItems { get; set; }
    }
}
