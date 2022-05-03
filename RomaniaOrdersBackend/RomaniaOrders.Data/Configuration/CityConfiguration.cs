namespace RomaniaOrders.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using RomaniaOrders.Data.Models;

    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> city)
        {
            city.HasKey(c => c.Id);

            city
                .Property(c => c.Name)
                .IsRequired();

            city
                .HasMany(c => c.Clients)
                .WithOne(cl => cl.City)
                .HasForeignKey(c => c.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            city
                .HasMany(c => c.Societies)
                .WithOne(s => s.City)
                .HasForeignKey(s => s.CityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
