namespace RomaniaOrders.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("group")]
    public class Group
    {
        public Group()
        {
            Societies = new HashSet<Society>();
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public ICollection<Society> Societies { get; set; }
    }
}
