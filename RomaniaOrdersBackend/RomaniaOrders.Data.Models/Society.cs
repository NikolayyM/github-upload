namespace RomaniaOrders.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("society")]
    public class Society
    {
        public Society()
        {
            Clients = new HashSet<Client>();
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("city_id")]
        public int CityId { get; set; }
        public City City { get; set; }

        [Column("group_id")]
        public int? GroupId { get; set; }
        public Group Group { get; set; }

        public ICollection<Client> Clients { get; set; }
    }
}
