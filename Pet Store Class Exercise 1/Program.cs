

using Pet_Store_Class_Exercise_1;

    public static class PetStore
    {
 
    
    
 
    public static void Main(string[] args)
    {



        Console.WriteLine("Welcome the Pet Store  Type 1 to enter a product, to search for a product press 8 type exit to quit");


        /*
                string? userInput = string.Empty;
                Console.WriteLine("Welcome the Pet Store  Type 1 to enter a product, to search for a product press 8 type exit to quit");

                userInput = Console.ReadLine();
                ProductLogic productLogic = new ProductLogic();
                while ( userInput != null && userInput.ToLower().Trim() != "exit")
                {

                    try
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

                                userInput = Console.ReadLine();

                                string? name = userInput;

                                Console.WriteLine("Enter Description of Product");

                                userInput = Console.ReadLine();
                                string? description = userInput;

                                Console.WriteLine("Enter Price of Product");
                                userInput = Console.ReadLine();
                                decimal price = decimal.Parse(userInput);

                                Console.WriteLine("Enter Quantity of Product");
                                userInput = Console.ReadLine();
                                int quantity = int.Parse(userInput);

                                Console.WriteLine("Enter Length of Product");
                                userInput = Console.ReadLine();

                                decimal length = decimal.Parse(userInput);

                                Console.WriteLine("Enter Type of Material of Product");

                                userInput = Console.ReadLine();

                                string? material = userInput;


                                dogLeash.Quantity = quantity;
                                dogLeash.Name = name;
                                dogLeash.Price = price;
                                dogLeash.Description = description;

                                dogLeash.Material = material;

                                dogLeash.LengthInches = (int)length;
                                Console.WriteLine($"Cat Food {dogLeash.ToString()}");
                            }
                            else if(userInput == "cat food")
                            {
                                CatFood catFood = new CatFood();
                                Console.WriteLine("Enter cat food parameters");

                                Console.WriteLine("Enter Name of Product");

                                userInput = Console.ReadLine();

                                string? name = userInput;

                                Console.WriteLine("Enter Description of Product");

                                userInput = Console.ReadLine();
                                string? description = userInput;

                                Console.WriteLine("Enter Price of Product");
                                userInput = Console.ReadLine();
                                decimal price = decimal.Parse(userInput);

                                Console.WriteLine("Enter Quantity of Product");
                                userInput = Console.ReadLine();
                                int quantity = int.Parse(userInput);


                                userInput = Console.ReadLine();
                                bool isKittenFood = false;
                                if(userInput == "kitten food")
                                {
                                    isKittenFood = true;
                                }
                                Console.WriteLine("Enter weight of Product");
                                userInput = Console.ReadLine();
                                int weight = int.Parse(userInput);
                                catFood.Quantity = quantity;
                                catFood.Name = name;
                                catFood.Price = price;
                                catFood.Description = description;
                                catFood.WeightPounds = weight;
                                catFood.KittenFood = isKittenFood;
                                Console.WriteLine($"Cat Food {catFood.ToString()}");
                            }
                        }

                        else if (userInput == "8")
                        {
                            Console.WriteLine("Type 2 to find dog leash by name");
                            Console.WriteLine("Tyoe 3 to find catfood by name");
                            userInput = Console.ReadLine();
                            if (userInput?.ToLower().Trim() == "2")
                            {
                                DogLeash? dogLeash = null;
                                Console.WriteLine("Enter Name of Dog Leash");
                                userInput = Console.ReadLine();
                                try
                                {
                                    dogLeash = productLogic.GetDogLeashByName(userInput);

                                }
                                catch(Exception ex)
                                {
                                    continue;
                                }
                                if (dogLeash != null)
                                {
                                    Console.WriteLine($"{dogLeash.ToString()}");

                                }

                            }
                           else if (userInput?.ToLower().Trim() == "3")
                            {
                                CatFood? catFood = null;
                                Console.WriteLine("Enter Name of cat food");
                                userInput = Console.ReadLine();
                                try
                                {
                                    catFood = productLogic.GetCatFoodByName(userInput);

                                }
                                catch (Exception ex)
                                {
                                    continue;
                                }
                                if (catFood != null)
                                {
                                    Console.WriteLine($"{catFood.ToString()}");

                                }

                            }

                            userInput = Console.ReadLine();
                        }
                    }

                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }

                }

        */
    }

}


