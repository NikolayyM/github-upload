namespace RomaniaOrders.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using RomaniaOrders.Data.Models;

    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> region)
        {
            region.HasKey(r => r.Id);

            region
                .Property(r => r.Name)
                .IsRequired();

            region
                .HasMany(r => r.Counties)
                .WithOne(c => c.Region)
                .HasForeignKey(c => c.RegionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
