using API.Core.DbModels;
using Microsoft.EntityFrameworkCore;

namespace API.Infastructure.DataContext
{
    public class StoreContext : DbContext
    {
        public StoreContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
