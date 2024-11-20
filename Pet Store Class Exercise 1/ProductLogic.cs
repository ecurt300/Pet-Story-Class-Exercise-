using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;


namespace Pet_Store_Class_Exercise_1
{

    public class ProductLogic : IProductLogic
    {
        List<Product> products = new List<Product>();
        Dictionary<string,Product> productDictionary = new Dictionary<string, Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);
            productDictionary.Add(product.Name, product);
        }

        public void GetAllProducts()
        {
           foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
            }
        }

        public List<string?> GetOnlyInStockProducts()
        {
            return products.Where(p => p.Quantity == 0).Select(p => p.Name).ToList();
        }

        public Product? GetProductByName(string name)
        {
            try
            {
                Product product = productDictionary[name];

                return product;
            }
            catch
            {
                Console.WriteLine($"Sorry product of {name} was not found. ");
            }
            return null;
        }
    }

}
