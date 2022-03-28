using Project.Space.Sloth.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Project.Space.Sloth.Domain.Orders;

namespace Project.Space.Sloth.Data{
    public class StoreContext : DbContext{
        public StoreContext(DbContextOptions<StoreContext> options) : base (options) {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }

    }

}
