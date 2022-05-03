namespace RomaniaOrders.Services.Models.Order
{
    using System;

    public class CreateOrderServiceModel
    {
        public int DistributorId { get; set; }

        public int ClientId { get; set; }

        public DateTime Date { get; set; }

        public string Comment { get; set; }

        public decimal Amount { get; set; }

        public decimal RebateAmount { get; set; }
    }
}
