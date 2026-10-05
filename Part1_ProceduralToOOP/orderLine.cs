using System;
using System.Collections.Generic;
using System.Text;

namespace oopTask1
{
    public class orderLine
    {
  
        public Product _product { get; }
         int lineQuantities { get; set; }
        public orderLine(int orderLineCounts, Product product, int lineQuantities)
        {
             this._product = product;
            this.lineQuantities = lineQuantities;
        }

       
    }
}

