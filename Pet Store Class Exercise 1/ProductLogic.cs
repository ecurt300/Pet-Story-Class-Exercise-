using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Store_Class_Exercise_1
{
    public  class ProductLogic : IProductLogic
    {
        private static List<Product>? _products = new List<Product>();

        private static Dictionary<string,Product> _productDictionary = new Dictionary<string, Product>();

       
        //Need to fix possible roadblock I really want to make some of this with generics
        
        public List<string?> GetOnlyInStockProducts()
        {
          
          
           return _products.Where(p => p.Quantity == 0).Select(p => p.Name).ToList();
        }

        public ProductLogic()
        {
            Product product0 = new Product("",0,0,"");
            Product product1 = new Product("", 0, 0, "");
            Product product2 = new Product("", 0, 0, "");
            _products?.Add(product0);
            _products?.Add(product1);
            _products?.Add(product2);
        }
        

        public void AddProduct(Product product)
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

        public Product? GetProductByName(string name)
        {
            
            try
            {
                Product product = _productDictionary[name];
               
                return product;
            }
            catch
            {
                Console.WriteLine($"Sorry product of {name} was not found. ");
            }
            return null;
        }
      
        public void GetAllProducts()
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
