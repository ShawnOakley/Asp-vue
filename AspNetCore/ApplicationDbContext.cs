using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Controller {
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {  }

        public DbSet<FoodRecord> FoodRecords { get; set; }
    }
}