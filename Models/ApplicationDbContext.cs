using Microsoft.EntityFrameworkCore;

namespace CupcakeMVC.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<DoubleMenu> DoubleMenus { get; set; }
        public DbSet<Drinks> Drink { get; set; }
    }
}
