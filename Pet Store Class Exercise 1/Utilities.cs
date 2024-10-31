using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utitlies
{
    public static class Utilities
    {

        public static string? ReadInputString()
        {

            return Console.ReadLine();
        }
        public static int? ReadInputInt()
        {
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int value))
                return value;
            Console.WriteLine("Invalid Input");
            return default;
        }

        public static double? ReadInputDouble()
        {
            string? input = Console.ReadLine();

            if (double.TryParse(input, out double value))
                return value;
            Console.WriteLine("Invalid Input");
            return default;
        }

        public static decimal? ReadInputDecimal()
        {
            string? input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal value))
                return value;
            Console.WriteLine("Invalid Input");
            return default;
        }

        public static bool CheckInput(string? paremeter)
        {
            string? input = Console.ReadLine();
            if (input == paremeter)
            {
                return true;
            }
            return false;
        }


    }
}
