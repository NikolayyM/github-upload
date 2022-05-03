namespace RomaniaOrders.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("producer")]
    public class Producer
    {
        public Producer()
        {
            Brands = new HashSet<Brand>();
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public ICollection<Brand> Brands { get; set; }
    }
}
