using _15December2021.Models;
using Microsoft.EntityFrameworkCore;

namespace _15December2021.DAL
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
    }
}