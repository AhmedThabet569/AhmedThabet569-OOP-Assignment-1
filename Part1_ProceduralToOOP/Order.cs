using System;
using System.Collections.Generic;
using System.Text;

namespace oopTask1
{
    public class Order
    {
        public int orderId { get; set;}
 
        public Customer customer { get; }

        public Product product { get; }
        public orderLine[] OrderLine { get; }
        public string orderDates { get; set;}
        public bool orderIsPaid { get; set;}
    
        public Order(int orderId, Customer customer, Product product, orderLine orderLine ,string orderDates, bool orderIsPaid)
        {
            this.orderId = orderId;
            if(customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "Customer cannot be null.");
            }
            this.customer = customer;
            this.product = product;
            this.OrderLine = orderLine;
            this.orderDates = orderDates;
            this.orderIsPaid = orderIsPaid;
        }
    }
}
