namespace RomaniaOrders.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using RomaniaOrders.Data.Models;

    public class DistributorConfiguration : IEntityTypeConfiguration<Distributor>
    {
        public void Configure(EntityTypeBuilder<Distributor> distributor)
        {
            distributor.HasKey(d => d.Id);

            distributor
                .Property(d => d.Name)
                .IsRequired();

            distributor
                .HasMany(d => d.Orders)
                .WithOne(o => o.Distributor)
                .HasForeignKey(o => o.DistributorId)
                .OnDelete(DeleteBehavior.Restrict);

            distributor
                .HasMany(d => d.ProductPrices)
                .WithOne(p => p.Distributor)
                .HasForeignKey(p => p.DistributorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
