using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class OrderLine
    {
        public int OrderLineID { get; set; }

        public int OrderLineNr { get; set; }

        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public ICollection<Order> Order {get;set;}

        public ICollection<Product> Product { get; set; }

    }
}
