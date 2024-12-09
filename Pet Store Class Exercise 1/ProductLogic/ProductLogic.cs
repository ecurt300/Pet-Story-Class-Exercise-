using Pet_Store_Class_Exercise;
using Pet_Store_Class_Exercise_1.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Pet_Store_Class_Exercise_1.ProductLogic
{

    public class ProductLogic : IProductLogic
    {
        List<Product> products = new List<Product>();
        Dictionary<string, Product> productDictionary = new Dictionary<string, Product>();
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

        public List<Product> GetOnlyInStockProducts()
        {

            return products.InStock().ToList();
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

        public decimal? GetTotalProductPrice()
        {
            var productInstockList = ListExtensions.InStock(products).ToList();
            var query = productInstockList.Select(product => product.Price).ToList();

            return query.Sum();
        }
    }



}
