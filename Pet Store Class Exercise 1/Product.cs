using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Store_Class_Exercise_1
{
    public class Product
    {
    
        public string? Name { get; private set; }
        
        public decimal Price { get; private set; }
        
        public int Quantity { get; private set; }

        public string? Description {  get; private set; }

        public void SetName(string? name)
        {
            Name = name;
        }
        public void SetPrice(decimal price)
        {
            Price = price;
        }

        public void AddQuantity(int quantity)
        {
            Quantity = quantity;
        }
        public void AddDescription(string? description)
        {
            Description = description;
        }
    }
}
