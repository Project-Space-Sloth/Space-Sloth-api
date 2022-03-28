using Project.Space.Sloth.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Project.Space.Sloth.Data{
    public class StoreContext : DbContext{
        public StoreContext(DbContextOptions<StoreContext> options) : base (options) {

        }

        public DbSet<Item> Items { get; set; }

    }

}
