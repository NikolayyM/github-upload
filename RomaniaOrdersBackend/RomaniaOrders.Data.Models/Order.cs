namespace RomaniaOrders.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("order")]
    public class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("comment")]
        public string Comment { get; set; }

        [Column("amount")]
        public decimal Amount { get; set; }

        [Column("rebate_amount")]
        public decimal RebateAmount { get; set; }

        [Column("total")]
        public decimal Total { get; set; }

        [Column("distributor_id")]
        public int DistributorId { get; set; }
        public Distributor Distributor { get; set; }

        [Column("client_id")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
