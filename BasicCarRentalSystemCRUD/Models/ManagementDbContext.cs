using Microsoft.EntityFrameworkCore;

namespace BasicCarRentalSystemCRUD.Models
{
    public class ManagementDbContext : DbContext
    {
        public DbSet<CarRenter> Management { get; set; }

        public ManagementDbContext(DbContextOptions<ManagementDbContext> options) : base(options)
        {
            
        }
    }
}
