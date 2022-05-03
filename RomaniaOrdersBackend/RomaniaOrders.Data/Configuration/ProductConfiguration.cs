namespace RomaniaOrders.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using RomaniaOrders.Data.Models;

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> product)
        {
            product.HasKey(p => p.Id);

            product
                .Property(p => p.Name)
                .IsRequired();

            product
                .Property(p => p.RomanianName)
                .IsRequired();

            product
                .Property(p => p.IsActive)
                .HasColumnType("bit");

            product
                .HasMany(p => p.OrderDetails)
                .WithOne(od => od.Product)
                .HasForeignKey(od => od.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
            
            product
                .HasMany(p => p.ProductPrices)
                .WithOne(pr => pr.Product)
                .HasForeignKey(pr => pr.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
