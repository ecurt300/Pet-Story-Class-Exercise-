using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Pet_Store_Class_Exercise_1.Products;

namespace Pet_Store_Class_Exercise
{
    public static class ListExtensions
    {
        public static List<T> InStock<T>(this List<T> list) where T : Product
        {
            return InStock<T>(new List<T>());
        }
    }
}
