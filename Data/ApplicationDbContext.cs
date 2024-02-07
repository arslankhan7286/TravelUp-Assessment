using Microsoft.EntityFrameworkCore;
using TravelUp.Models;


namespace TravelUp.Data
{

    public class ApplicationDbContext : DbContext
    {
        public DbSet<ItemModel> Items { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
