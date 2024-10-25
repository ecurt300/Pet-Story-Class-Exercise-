using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Store_Class_Exercise_1
{
    internal class ProductLogic
    {
        private List<Product> _products;

        private Dictionary<string,DogLeash> _dogLeashes;

        private Dictionary<string,CatFood> _catFoods;

        public void AddProduct(Product product)
        {
            _products.Add(product);
            if(product is DogLeash)
            {
                _dogLeashes.Add(product.Name,product as DogLeash);
            }
            else if(product is CatFood)
            {
                _catFoods.Add(product.Name, product as CatFood);
            }
        }

        public DogLeash GetDogLeashByName(string name)
        {
            return _dogLeashes[name];
        }
        public CatFood GetCatFoodByName(string name)
        {
            return _catFoods[name];
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
            _dogLeashes = new Dictionary<string, DogLeash>();
            _catFoods = new Dictionary<string,CatFood>();
        }


    }
}
