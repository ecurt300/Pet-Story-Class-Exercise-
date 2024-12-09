using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pet_Store_Class_Exercise_1.Products;

namespace Pet_Store_Class_Exercise_1.ProductLogic
{
    public interface IProductLogic
    {
        public List<Product?> GetOnlyInStockProducts();
        public void GetAllProducts();

        public void AddProduct(Product product);

        public Product? GetProductByName(string name);

        public decimal? GetTotalProductPrice();
    }
}
