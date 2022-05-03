namespace RomaniaOrders.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("region")]
    public class Region
    {
        public Region()
        {
            Counties = new HashSet<County>();
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public ICollection<County> Counties { get; set; }
    }
}
