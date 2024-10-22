// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using System.Text.Json;
using Pet_Store_Class_Exercise_1;

    public static class PetStore
    {

       private static Product AddProduct(string productName,string description,decimal price,int quantity,int weight, bool isKittenFood)
        {
            return new CatFood(weight, isKittenFood, price, quantity, productName,description);
        }


        
        private static Product AddProduct(string productName,string description, decimal price, int quantity, int length,string material)
        {
            return new DogLeash(length,material, price, quantity, productName,description);
        }

        private static void DisplayInstructions()
    {
        Console.WriteLine("Press 1 to add a product; choose between cat food or a dog leash; press 8 to view all added products");


        Console.WriteLine("Type 'exit' to quit");
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




             DisplayInstructions();


            ProductLogic productLogic = new ProductLogic();
            string? userInput = Console.ReadLine();
       
            while (!userInput.ToLower().Equals("exit"))
            {





                if (userInput.Equals("1"))
                {
                  


                    Console.WriteLine(" Type dogleash for dogleash or catfood for catfood then follow the instructions.");

                    
                    


                    string? productType = Console.ReadLine();


                    if (productType == "dogleash")
                    {
                        Console.WriteLine("Enter dog leash parameters");
                        
                        Console.WriteLine("Enter Name of Product");
                        
                        string name = Console.ReadLine();
                        
                        Console.WriteLine("Enter Material of Product");

                        string material = Console.ReadLine(); ;
                        Console.WriteLine("Enter Description of Product");

                        string description = Console.ReadLine();

                        
                        
                        Console.WriteLine("Enter Price of Product");
                        
                        decimal price = decimal.Parse(Console.ReadLine());
                       
                        Console.WriteLine("Enter Quantity of Product");
                       
                        int quantity = int.Parse( Console.ReadLine());
                        
                        Console.WriteLine("Enter Length in inches of Product");
                        
                        int length = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter weight in ibs of Product");
                        int weight = int.Parse(Console.ReadLine());
                        Product dogLeash = AddProduct(name,description,price,quantity,length,material);
                        productLogic.AddProduct(dogLeash);
                        Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                        DisplayInstructions();
                    }
                    else if (productType.Equals("catfood"))
                    {

                        Console.WriteLine("Enter cat food parameters");

                        Console.WriteLine("Enter Name of Product");
                        
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter Description of Product");

                        string description = Console.ReadLine();

                        Console.WriteLine("Enter Price of Product");
                       
                        decimal price = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Quantity of Product");
                        
                        int quantity = int.Parse(Console.ReadLine());


                        Console.WriteLine("Enter weight of Product");
                       
                        int weight = int.Parse(Console.ReadLine());

                     


                    Console.WriteLine("Is product for kittens?, Enter yes for kittenfood if applicable");

                        bool kittenFood;
                        if (Console.ReadLine().Equals("yes"))
                        {
                            kittenFood = true;
                           
                            Console.WriteLine($"{Console.ReadLine()} is kittenfood.");
                        }
                        else
                        {
                            Console.WriteLine($"I am sorry {Console.ReadLine()} is not a valid answer please try again.");
                            continue;
                        }
                      Product catfood = AddProduct(name,description,price, quantity, weight, kittenFood);
                     productLogic.AddProduct(catfood);
                    Console.WriteLine(JsonSerializer.Serialize(catfood));
                     DisplayInstructions();
                    }
                }
                else if(userInput.Equals("8"))
                {
                    productLogic.GetAllProducts();
                }
                userInput = Console.ReadLine();
            }
           

        }
        
    }

