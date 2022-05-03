namespace RomaniaOrders.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("distributor")]
    public class Distributor
    {
        public Distributor()
        {
            Orders = new HashSet<Order>();
            ProductPrices = new HashSet<ProductPrices>();
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("exchange_rate")]
        public decimal ExchangeRate { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<ProductPrices> ProductPrices { get; set; }
    }
}
