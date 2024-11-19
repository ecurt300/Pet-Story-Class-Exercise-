using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Store_Class_Exercise_1
{
    public interface IProductLogic
    {
        public void AddProduct(Product product);

        public Product? GetProductByName(string name);

        public void GetAllProducts();

        public List<string?> GetOnlyInStockProducts();
      
    }
}
