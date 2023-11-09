using _5letters.Models;
using Microsoft.EntityFrameworkCore;

namespace _5letters.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<CorrectWord> CorrectWords { get; set; }
        public DbSet<Models.Game> Games { get; set; }
        public DbSet<Models.Word> Words { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
