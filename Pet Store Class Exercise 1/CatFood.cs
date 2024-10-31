using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Store_Class_Exercise_1
{
    public class CatFood : Product
    {
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
