using System.Collections.Generic;

namespace EfCore2020.Entities
{
    public sealed class Customer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public List<Order> Orders { get; set; }
    }
}
