using Microsoft.EntityFrameworkCore;

namespace ClientsAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Clients> Clients => Set<Clients>();
    }
}
