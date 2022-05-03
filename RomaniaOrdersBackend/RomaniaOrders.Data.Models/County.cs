namespace RomaniaOrders.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("county")]
    public class County
    {
        public County()
        {
            Cities = new HashSet<City>();
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("region_id")]
        public int RegionId { get; set; }
        public Region Region { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
