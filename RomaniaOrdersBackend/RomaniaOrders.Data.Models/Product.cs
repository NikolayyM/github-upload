namespace RomaniaOrders.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("product")]
    public class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetails>();
            ProductPrices = new HashSet<ProductPrices>();
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("romanian_name")]
        public string RomanianName { get; set; }

        [Column("vat")]
        public int Vat { get; set; }

        [Column("base_price")]
        public decimal BasePrice { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }

        [Column("brand_id")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }

        public ICollection<ProductPrices> ProductPrices { get; set; }
    }
}
