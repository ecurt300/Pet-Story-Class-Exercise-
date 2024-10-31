using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Store_Class_Exercise_1
{
    public class DogLeash : Product
    {
    
        public int LengthInches {  get; set; }

        public string? Material {  get; set; }

        public void SetLength(int length)
        {
            LengthInches = length;
        }
        
        public void SetMaterial(string? material)
        {
            
            Material = material;
        }
    }
}
