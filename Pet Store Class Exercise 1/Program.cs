

using Pet_Store_Class_Exercise_1;
using Utilities;
public static class PetStore
{
 
    
    
 
    public static void Main(string[] args)
    { 


        
                string? userInput = string.Empty;
                Console.WriteLine("Welcome the Pet Store  Type 1 to enter a product, to search for a product press 8 type exit to quit");

                userInput = Utilities.Utilities.ReadInputString();
                 
                while ( userInput != null && userInput.ToLower().Trim() != "exit")
                {

                  
                        if (userInput == "1")
                        {
                            Console.WriteLine("Please enter the type of product press type 'dogleash' for leash ; type 'catfood for catfood");
                            userInput = Console.ReadLine();
                            if(userInput == "dogleash")
                            {
                                DogLeash dogLeash = new DogLeash();
                                Console.WriteLine("Enter dogLeash parameters");

                                Console.WriteLine("Enter Name of Product");

                                userInput = Utilities.Utilities.ReadInputString();

                                string? name = userInput;

                                Console.WriteLine("Enter Description of Product");

                               
                                string? description = Utilities.Utilities.ReadInputString();

                                Console.WriteLine("Enter Price of Product");
                              
                                decimal price = (decimal)Utilities.Utilities.ReadInputDecimal();

                                Console.WriteLine("Enter Quantity of Product");
                            
                                int quantity = (int)Utilities.Utilities.ReadInputInt();

                                Console.WriteLine("Enter Length of Product");

                           
                                decimal length = (decimal)Utilities.Utilities.ReadInputDecimal();

                                Console.WriteLine("Enter Type of Material of Product");

                                string? material = Utilities.Utilities.ReadInputString();

                                dogLeash.Material = material;

                                dogLeash.LengthInches = (int)length;
                                Console.WriteLine($"Dogleash {dogLeash.ToString()}");
                            }
                            if(userInput == "cat food")
                            {
                                CatFood catFood = new CatFood();
                                Console.WriteLine("Enter cat food parameters");

                                Console.WriteLine("Enter Name of Product");

                                userInput = Utilities.Utilities.ReadInputString();

                                string? name = Utilities.Utilities.ReadInputString();

                                Console.WriteLine("Enter Description of Product");

                                
                                string? description = Utilities.Utilities.ReadInputString(); ;

                                Console.WriteLine("Enter Price of Product");
                               
                                decimal price = ((decimal)Utilities.Utilities.ReadInputDecimal());

                                Console.WriteLine("Enter Quantity of Product");
                              
                                int quantity = (int)(Utilities.Utilities.ReadInputInt());


                                userInput = Utilities.Utilities.ReadInputString();
                                bool isKittenFood = false;
                                if(userInput == "kitten food")
                                {
                                    isKittenFood = Utilities.Utilities.CheckInput("kitten food");
                                }
                                Console.WriteLine("Enter weight of Product");
                               
                                int weight = (int)Utilities.Utilities.ReadInputInt();
                              
                                Console.WriteLine($"Cat Food {catFood.ToString()}");
                            }
                        }

                        if (userInput == "8")
                        {
                            Console.WriteLine("Type 2 to find dog leash by name");
                            Console.WriteLine("Tyoe 3 to find catfood by name");
                            userInput = Utilities.Utilities.ReadInputString();
                            if (userInput?.ToLower().Trim() == "2")
                            {
                                DogLeash? dogLeash = null;
                                Console.WriteLine("Enter Name of Dog Leash");
                                userInput = Console.ReadLine();
                               
                                dogLeash = (DogLeash?)ProductLogic.GetProductByName(userInput);
                                
                             
                                

                                
                               

                            }
                           else if (userInput?.ToLower().Trim() == "3")
                            {
                                CatFood? catFood = null;
                                Console.WriteLine("Enter Name of cat food");
                                userInput = Utilities.Utilities.ReadInputString();

                                if (catFood != null)
                                {
                                    Console.WriteLine($"{catFood.ToString()}");

                                }

                            }

                            userInput = Utilities.Utilities.ReadInputString();
                        }
                    

                }

        
    }

}


