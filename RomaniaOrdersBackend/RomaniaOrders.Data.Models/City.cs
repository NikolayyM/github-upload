namespace RomaniaOrders.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("city")]
    public class City
    {
        public City()
        {
            Clients = new HashSet<Client>();
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("county_id")]
        public int CountyId { get; set; }
        public County County { get; set; }

        public ICollection<Client> Clients { get; set; }

        public ICollection<Society> Societies { get; set; }
    }
}
