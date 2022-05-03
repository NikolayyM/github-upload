namespace RomaniaOrders.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using RomaniaOrders.Data.Models;

    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> brand)
        {
            brand.HasKey(b => b.Id);

            brand
                .Property(b => b.Name)
                .IsRequired()
                .IsUnicode();

            brand
                .HasMany(p => p.Products)
                .WithOne(b => b.Brand)
                .HasForeignKey(b => b.BrandId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
