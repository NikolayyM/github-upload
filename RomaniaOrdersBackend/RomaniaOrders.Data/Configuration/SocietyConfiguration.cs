namespace RomaniaOrders.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using RomaniaOrders.Data.Models;

    public class SocietyConfiguration : IEntityTypeConfiguration<Society>
    {
        public void Configure(EntityTypeBuilder<Society> society)
        {
            society.HasKey(s => s.Id);

            society
                .Property(s => s.Name)
                .IsRequired();

            society
                .Property(s => s.Address)
                .IsRequired();

            society
                .HasMany(s => s.Clients)
                .WithOne(c => c.Society)
                .HasForeignKey(c => c.SocietyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
