namespace RomaniaOrders.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("brand")]
    public class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("producer_id")]
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
