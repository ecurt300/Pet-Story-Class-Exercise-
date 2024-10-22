using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Store_Class_Exercise_1
{
    internal class DogLeash : Product
    {
    
        public int LengthInches {  get; set; }

        public string? Material {  get; set; }

       public DogLeash(int length,string material,decimal price, int quantity, string name,string description) 
        { 
            this.Description = description;
            this.LengthInches = length;
            this.Material = material;
            this.Price = price;
            this.Quantity = quantity;
            this.Name = name;
        }

    }
}
