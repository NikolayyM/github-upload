namespace RomaniaOrders.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("order_details")]
    public class OrderDetails
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("order_id")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("rebate_quantity")]
        public int RebateQuantity { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
