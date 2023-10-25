using Microsoft.EntityFrameworkCore;

namespace _5letters.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
