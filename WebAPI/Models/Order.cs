using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Order
    {
        public int OrderID {get;set;}

        public int OrderDate { get; set; }

        public string OrderStatus { get; set; }

        public Product Product { get;set;}


        public int ProductID { get; set; }

        public Customer Customer { get; set; }


        public OrderLine OrderLine { get; set; }

        public int CustomerID { get; set; }

    }
}
