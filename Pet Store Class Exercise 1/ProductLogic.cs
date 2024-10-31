using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Store_Class_Exercise_1
{
    public static class ProductLogic
    {
        private static List<Product>? _products = new List<Product>();

        private static Dictionary<string,Product> _productDictionary = new Dictionary<string, Product>();

        

        public static void AddProduct(Product product)
        {
            _products?.Add(product);
            if(product is DogLeash)
            {
                _productDictionary.Add(product.Name,product as DogLeash);
            }
            else if(product is CatFood)
            {
                _productDictionary.Add(product.Name, product as CatFood);
            }
        }

        public static Product GetDogLeashByName(string name)
        {
            return _productDictionary[name];
        }
      
        public static void GetAllProducts()
        {
            if (_products != null)
            {
                foreach (Product product in _products)
                {
                    Console.WriteLine(product.Name);
                }
            }
        }
       
    }
}
