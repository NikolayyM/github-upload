namespace RomaniaOrders.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("product_prices")]
    public class ProductPrices
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Column("distributor_id")]
        public int DistributorId { get; set; }
        public Distributor Distributor { get; set; }

        [Column("prices_in_ron")]
        public decimal PriceInRON { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [Column("deleted_at")]
        public DateTime DeletedAt { get; set; }
    }
}
