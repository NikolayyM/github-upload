namespace RomaniaOrders.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using RomaniaOrders.Data.Models;

    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> client)
        {
            client.HasKey(c => c.Id);

            client
                .Property(c => c.Name)
                .IsRequired();

            client
                .Property(c => c.Address)
                .HasMaxLength(150)
                .IsRequired();

            client
                .Property(c => c.IsActive)
                .HasColumnType("bit");

            client
                .HasMany(c => c.Orders)
                .WithOne(o => o.Client)
                .HasForeignKey(o => o.ClientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
