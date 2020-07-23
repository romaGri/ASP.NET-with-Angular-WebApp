using System;

namespace backend.Models
{
    public class Order
    {
        
        public int Id { get; set; }
        public Customer Customre { get; set; }
        public decimal Total { get; set; }
        public DateTime Placed { get; set; }
        public DateTime? Completed { get; set; }

    }
}