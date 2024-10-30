using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Store_Class_Exercise_1
{
    internal class CatFood : Product
    {
        public double WeightPounds {  get; set; }

        public bool KittenFood {  get; set; }
        

        public CatFood(int weight , bool isKittenFood,decimal price,int quantity,string name,string description) 
        { 
            this.Description = description;
            this.Name = name;
            this.WeightPounds = weight;
            this.KittenFood = isKittenFood;
            this.Price = price;
            this.Quantity = quantity;
        }
        public CatFood()
        {

        }
    }
}
