using System;
using System.Collections.Generic;
using System.Text;

namespace oopTask1
{
    public  class Product
    {

        public int productId { get; set; }
        public string productName { get; set; }
        public double productPrices { get; set; }
        public int productStock { get; set; }
        public Product(int productId, string productName, double productPrices, int productStock)
        {
            this.productId = productId;
            this.productName = productName;
            this.productPrices = productPrices;
            this.productStock = productStock;
        }

    }
}
