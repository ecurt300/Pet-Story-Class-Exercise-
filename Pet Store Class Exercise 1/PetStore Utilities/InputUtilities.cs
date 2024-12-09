using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputUtilities
{
    public static class InputUtilities
    {

        public static string? ReadInputString()
        {

            



            return Console.ReadLine();
        }
        public static int? ReadInputInt()
        {
            string? input = Console.ReadLine();
            int value = 0;
            if (input != null && int.TryParse(input, out value))
            {
                return value;

            }
            Console.WriteLine("Invalid Input");
            return null;
        }

        public static double? ReadInputDouble()
        {
            string? input = Console.ReadLine();
            double value = 0;
            if (double.TryParse(input, out value))
                return value;
            Console.WriteLine("Invalid Input");
            return null;
        }

        public static decimal? ReadInputDecimal()
        {
            string? input = Console.ReadLine();
            decimal value = 0;
            if (input != null && decimal.TryParse(input, out value))
            {
                return value;

            }
            Console.WriteLine("Invalid Input");
            return null;
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
