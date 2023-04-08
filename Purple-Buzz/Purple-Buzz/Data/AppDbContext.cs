using Microsoft.EntityFrameworkCore;
using Purple_Buzz.Models;

namespace Purple_Buzz.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<HomeSlider> HomeSliders { get; set; }
        public DbSet<HomeServices> HomeServices { get; set; }
    }

}
