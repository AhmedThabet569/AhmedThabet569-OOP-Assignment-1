using System;
using System.Collections.Generic;
using System.Text;

namespace oopTask1
{
    public class customerServices
    {
         const int MAX_CUSTOMERS = 50;
        public readonly Customer[] _customers = new Customer[MAX_CUSTOMERS]; 
       public int customerCount = 0;
        public int findCustomerIndexById(int customerId)
        {
            for (int i = 0; i < _customers.Length; i++)
            {
                if (_customers[i].customerId == customerId)
                {
                    return i;
                }
            }
            return -1; // Return -1 if the customer is not found
        }
        public void  addCustomer(Customer newCustomer)
        {
            if (customerCount >= MAX_CUSTOMERS)
            {
                throw new InvalidOperationException("ERROR: Customer list is full.");
            }
            if (findCustomerIndexById(newCustomer.customerId) != -1)
            {
                throw new ArgumentException($"ERROR: Customer ID {newCustomer.customerId} already exists.");
            }

            _customers[customerCount] = newCustomer;
        }

        public void printCustomers()
        {
            Console.WriteLine($"\"\\n=== CUSTOMERS (\" << _customers.Length << \") ===\\n\"");
            foreach (var item in _customers)
            {
                
                Console.WriteLine($"# {item.customerId} \n {item.customerName} \n {item.customerEmail} \n {item.customerCity}" +
                    $"vip = {(item.customerIsVip ? "Yes" : "No")}");
            }
        }
        }
    }
    }
}
