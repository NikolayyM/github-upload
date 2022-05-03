namespace RomaniaOrders.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using RomaniaOrders.Data.Models;

    public class CountyConfiguration : IEntityTypeConfiguration<County>
    {
        public void Configure(EntityTypeBuilder<County> county)
        {
            county.HasKey(c => c.Id);

            county
                .Property(c => c.Name)
                .IsRequired();

            county
                .HasMany(c => c.Cities)
                .WithOne(ci => ci.County)
                .HasForeignKey(ci => ci.CountyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
