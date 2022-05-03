namespace RomaniaOrders.Services.Models.Order
{
    using System;

    public class AllOrdersServiceModel
    {
        public int Id { get; set; }

        public string ClientName { get; set; }

        public string County { get; set; }

        public string City { get; set; }

        public string Distributor { get; set; }

        public decimal Total { get; set; }

        public decimal RebateAmount { get; set; }

        public DateTime Date { get; set; }
    }
}
