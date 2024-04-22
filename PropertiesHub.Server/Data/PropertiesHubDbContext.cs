using Microsoft.EntityFrameworkCore;
using PropertiesHub.Server.Data.Models;

namespace PropertiesHub.Server.Data
{
    public class PropertiesHubDbContext : DbContext
    {

        public PropertiesHubDbContext(DbContextOptions<PropertiesHubDbContext> dbContextOptions)
            :base(dbContextOptions)
        {
            
        }
        public DbSet<Property> Properties { get; set; }
    }
}
