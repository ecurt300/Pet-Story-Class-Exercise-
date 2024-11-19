using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Store_Class_Exercise_1
{
    public class CatFood : Product
    {
        public CatFood(string name, decimal price, int quantity, string Description,double weightPounds,bool kittenFood) : base(name, price, quantity, Description)
        {
            this.WeightPounds = weightPounds;
            this.KittenFood = kittenFood;
        
        }

        public double WeightPounds {  get; private set; }

        public bool KittenFood {  get; private set; }
   
        public void SetKittenFood(bool isKittenFood) 
        { 
            KittenFood = isKittenFood;
        }

        public void SetWeightOfFood(double weight)
        {
            WeightPounds = weight;
        }
    }
}
