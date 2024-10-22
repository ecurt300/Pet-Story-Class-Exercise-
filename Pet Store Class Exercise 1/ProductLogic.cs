using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Store_Class_Exercise_1
{
    internal class ProductLogic
    {
        private List<Product> _products;


        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public void GetAllProducts()
        {
            foreach (Product product in _products)
            {
                Console.WriteLine(product.Name);
            }
        }
        public ProductLogic()
        {
            _products = new List<Product>();
        }


    }
}
