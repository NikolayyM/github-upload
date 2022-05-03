namespace RomaniaOrders.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("client")]
    public class Client
    {
        public Client()
        {
            Orders = new HashSet<Order>();
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

        [Column("is_active")]
        public bool IsActive { get; set; }

        [Column("society_id")]
        public int? SocietyId { get; set; }
        public Society Society { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdateAt { get; set; }

        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        public ICollection<Order> Orders { get; set; }


    }
}
