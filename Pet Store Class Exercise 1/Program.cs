// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using System.Text.Json;
namespace Pet_Store_Class_Exercise_1
{

    public static class PetStore
    {

       private static Product AddProduct(string productName,decimal price,int quantity,int weight, bool isKittenFood)
        {
            return new CatFood(weight, isKittenFood, price, quantity, productName);
        }


        
        private static Product AddProduct(string productName, decimal price, int quantity, int length,string material)
        {
            return new DogLeash(length,material, price, quantity, productName);
        }
    /*
        private static bool TryAddProduct(string product)
        {
            if(product.ToLower() == "dogleash" || product.ToLower() == "catfood")
            {
         

                Console.WriteLine($" product {product} has been selected");

                return true;
            }
            else
            {
                Console.WriteLine("Product does not exist, please enter a valid product");
                
            }

            return false;
        }
    */
        public static void Main(string[] args)
        {
          



            Console.WriteLine("Press 1 to add a product; choose between cat food or a dog leash");


            Console.WriteLine("Type 'exit' to quit");

            //TODO fix main loop duplicate answers.
            //TODO enter in dogleash info
            //TODO Add and print the Products
           

            while ( Console.ReadLine().ToLower() != "exit")
            {

                Console.WriteLine("Press 1 to add a product; choose between cat food or a dog leash");


                Console.WriteLine("Type 'exit' to quit");

                string? userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.Clear();
                    userInput = Console.ReadLine();
                   
                    Console.WriteLine(" Type dogleash for dogleash or catfood for catfood then follow the instructions.");
               
                       
                        if(Console.ReadLine().ToLower() == "dogleash")
                        {
                            Console.WriteLine("Enter dog leash parameters");
                            string name;
                            string material;
                            decimal price;
                            int quantity;
                            int length;


                        }
                        else if(Console.ReadLine().ToLower() == "catfood")
                        {
                        Console.Clear();
                        Console.WriteLine("Enter cat food parameters");
                        Console.Clear();
                        Console.WriteLine("Enter Name of Product");
                            string name = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Enter Name of Price of Product");
                        
                            decimal price = decimal.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Enter Quantity of Product");
                            int quantity = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Enter weight of Product");
                            int weight = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Is product for kittens?, Enter yes for kittenfood if applicable");
                            
                        bool kittenFood;
                            if (Console.ReadLine() == "yes")
                            {
                                kittenFood = true;
                                Console.Clear();
                                Console.WriteLine($"{name} is kittenfood.");
                            }
                            else
                            {
                                Console.WriteLine($"I am sorry {Console.ReadLine()} is not a valid answer please try again.");
                                 continue;
                            }
                         
                        
                    }
                   
                 

                   
                }

              
            }
            
            
        }
        
    }
}