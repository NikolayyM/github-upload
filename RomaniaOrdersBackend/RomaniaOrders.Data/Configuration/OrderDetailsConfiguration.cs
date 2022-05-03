namespace RomaniaOrders.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using RomaniaOrders.Data.Models;

    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> orderDetails)
        {
            orderDetails.HasKey(od => od.Id);
        }
    }
}
