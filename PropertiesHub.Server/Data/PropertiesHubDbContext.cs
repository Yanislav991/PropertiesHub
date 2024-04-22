using Microsoft.EntityFrameworkCore;
using PropertiesHub.Server.Data.Models;

namespace PropertiesHub.Server.Data
{
    public class PropertiesHubDbContext : DbContext
    {
        public DbSet<Property> Properties { get; set; }
    }
}
