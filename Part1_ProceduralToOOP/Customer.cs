using System;
using System.Collections.Generic;
using System.Text;

namespace oopTask1
{
    public  class Customer
    {  
        public int customerId { get; set; }
        public string customerName { get; set; } 
        public string customerEmail { get; set; }
        public string customerCity { get; set; } 
        public bool customerIsVip { get; set; }
        //method 
        public Customer(int customerId, string customerName, string customerEmail, string customerCity, bool customerIsVip)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.customerCity = customerCity;
            this.customerIsVip = customerIsVip;
        }
    }
}
