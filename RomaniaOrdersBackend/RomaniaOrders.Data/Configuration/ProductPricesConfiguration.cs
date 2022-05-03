namespace RomaniaOrders.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using RomaniaOrders.Data.Models;

    public class ProductPricesConfiguration : IEntityTypeConfiguration<ProductPrices>
    {
        public void Configure(EntityTypeBuilder<ProductPrices> productPrices)
        {
            productPrices.HasKey(p => p.Id);
        }
    }
}
