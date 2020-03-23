using System;

namespace EfCore2020.Entities
{
    public sealed class Order
    {
        public int OrderId { get; set; }

        public decimal TotalValue { get; set; }

        public DateTime Date { get; set; }

        public int CustomerCustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
