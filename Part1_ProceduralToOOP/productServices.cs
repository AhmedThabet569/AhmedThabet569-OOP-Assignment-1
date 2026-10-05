using System;
using System.Collections.Generic;
using System.Text;

namespace oopTask1
{
    public class productServices
    {
        const int MAX_PRODUCTS = 50;
         public readonly Product[] _products = new Product[MAX_PRODUCTS];
        int productCount = 0;

        public int findProductIndexById(int id)
        {
            for (int i = 0; i < _products.Length; i++)
            {
                if (_products[i].productId == id)
                    return i;
            }
            return -1;
        }

        public void addProduct(Product product)
        {
            int index = findProductIndexById(product.productId);

            if (productCount >= MAX_PRODUCTS)
            {
                 Console.WriteLine("ERROR: product list is full.\n");
                return;
            }
            if (index != -1)
            {
                Console.WriteLine($"ERROR: product id {product.productId} already exists.\n");
                return;
            }
            _products[productCount] = product; 
            productCount++;
        }
        public void printProducts()
        {
            Console.WriteLine($"\"\\n=== PRODUCTS (\" << _products.Length << \") ===\\n\"");
            foreach (var item in _products)
            {
                if (item != null)
                {
                    Console.WriteLine($"# {item.productId} \n {item.productName} \n {item.productPrices} \n {item.productStock}");
                }
            }
        }
    }
}
