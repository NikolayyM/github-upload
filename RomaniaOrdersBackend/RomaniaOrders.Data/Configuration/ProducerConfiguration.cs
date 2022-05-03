namespace RomaniaOrders.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using RomaniaOrders.Data.Models;

    public class ProducerConfiguration : IEntityTypeConfiguration<Producer>
    {
        public void Configure(EntityTypeBuilder<Producer> producer)
        {
            producer.HasKey(p => p.Id);

            producer
                .Property(p => p.Name)
                .IsRequired();

            producer
                .HasMany(p => p.Brands)
                .WithOne(b => b.Producer)
                .HasForeignKey(b => b.ProducerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
