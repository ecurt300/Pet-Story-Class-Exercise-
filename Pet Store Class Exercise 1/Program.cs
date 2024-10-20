// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using System.Text.Json;
namespace Pet_Store_Class_Exercise_1
{

    public static class PetStore
    {


      


        public static void Main(string[] args)
        {
          
          
           

            Console.WriteLine("Press 1 to add a product");

            Console.WriteLine("Type 'exit' to quit");
            
            string? userInput = Console.ReadLine();









            while (userInput?.ToLower() != "exit")
            {

                if (userInput == "1")
                {


                    Console.WriteLine("Dog Leash Selected, now add the leash lengths in inches");
                    DogLeash dogLeash = new DogLeash();
                    #pragma warning disable CS8604 // Possible null reference argument.
                    dogLeash.LengthInches = int.Parse(userInput = Console.ReadLine());
                    #pragma warning restore CS8604 // Possible null reference argument.
                    Console.WriteLine("Leash Length is " +  dogLeash.LengthInches + "Now set the material");
                    dogLeash.Material = (userInput = Console.ReadLine());
                    Console.WriteLine($"Dog leash Material is {dogLeash.Material}");
                    
                    Console.WriteLine(JsonSerializer.Serialize(dogLeash).ToString());
                }

                    

               
                
                userInput = Console.ReadLine();
            }
      
            
        }
    }
}