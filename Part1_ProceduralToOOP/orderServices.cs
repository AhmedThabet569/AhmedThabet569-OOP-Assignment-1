using System;
using System.Collections.Generic;
using System.Text;

namespace oopTask1
{
    public class orderServices
    {
        const int MAX_ORDERS = 100;
        const int maxOrderLines = 10;
        public readonly Order[] orders = new Order[MAX_ORDERS];
        public int orderC = 0;

        public int GetOrderById(int orderId)
        {
            for (int i = 0; i < orders.Length; i++)
            {
                if (orders[i] != null && orders[i].orderId == orderId)
                {
                    Console.WriteLine($"Order ID: {orders[i].orderId}");
                    return i;
                }
            }
            return -1; // Return -1 if the order is not found
        }
        public int createOrder(Order order)
        {
            if (orderC >= MAX_ORDERS)
            {
                throw new InvalidOperationException("ERROR: Customer list is full.");
            }
            if (GetOrderById(order.orderId) != -1)
            {
                throw new ArgumentException($"ERROR: Order  ID {order.orderId} already exists.");
            }
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order), "Order cannot be null.");
            }
            if (order.customer == null)
            {
                throw new ArgumentNullException(nameof(order.customer), "Customer cannot be null.");
            }

            orders[orderC] = order;
            int index = orderC;
            orderC++;
            return index;
        }

        //public bool addLineToOrder(Order order, Product product, int quntity)
        //{

        //    if(GetOrderById(order.orderId) == -1)
        //    {
        //        throw new ArgumentException($"ERROR: Order ID {order.orderId} dont found.");
        //    }
        //    if(order.orderIsPaid)
        //    {
        //        throw new InvalidOperationException($"ERROR: cannot change a paid order.");
        //    }
        //    if (quntity <= 0)
        //    {
        //        Console.WriteLine("ERROR: quantity must be positive.");
        //        return false;
        //    }
        //    if (order.OrderLine.Length >= maxOrderLines)
        //    {
        //        throw new InvalidOperationException($"ERROR: Order ID {order.orderId} has reached the maximum number of order lines.");
        //    }

        //}
        public double calculateOrderTotal(Order order)
        {
             decimal total = 0;
            for (int i = 0; i < maxOrderLines; i++)
            {
                total += maxOrderLines[i]
            }
        }
        

        }
    }
}

