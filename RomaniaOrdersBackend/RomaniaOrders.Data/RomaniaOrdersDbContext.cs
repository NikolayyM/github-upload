namespace RomaniaOrders.Data
{
    using Microsoft.EntityFrameworkCore;

    using RomaniaOrders.Data.Models;

    public class RomaniaOrdersDbContext : DbContext
    {

        public DbSet<Brand> Brands { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Distributor> Distributors { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPrices> ProductPrices { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Society> Societies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(DataSettings.Connection, ServerVersion.AutoDetect(DataSettings.Connection));
        }

        protected override void OnModelCreating(ModelBuilder builder)
            => builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
    }
}
