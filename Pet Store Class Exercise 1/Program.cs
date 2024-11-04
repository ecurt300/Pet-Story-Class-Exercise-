
using System.Text.Json;
using Pet_Store_Class_Exercise_1;
using Utilities;
#pragma warning disable CS8629
public static class PetStore
{
    private static void SearchProduct(string? userInput)
    {
        Console.WriteLine("Type 2 to find dog leash by name");
        Console.WriteLine("Tyoe 3 to find catfood by name");
        userInput = Utilities.Utilities.ReadInputString();
        if (userInput?.ToLower().Trim() == "2")
        {
            DogLeash? dogLeash = null;
            Console.WriteLine("Enter Name of Dog Leash");
            userInput = Utilities.Utilities.ReadInputString();

            dogLeash = (DogLeash?)ProductLogic.GetProductByName(userInput);



            if (dogLeash != null)
            {
                Console.WriteLine($"{JsonSerializer.Serialize(dogLeash)}");
            }



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
    }
    private static void ChooseCatFood()
    {
        CatFood catFood = new CatFood();
        Console.WriteLine("Enter cat food parameters");

        Console.WriteLine("Enter Name of Product");

       ;

        string? name = Utilities.Utilities.ReadInputString();

        Console.WriteLine("Enter Description of Product");


        string? description = Utilities.Utilities.ReadInputString(); ;

        Console.WriteLine("Enter Price of Product");

        decimal price = ((decimal)Utilities.Utilities.ReadInputDecimal());

        Console.WriteLine("Enter Quantity of Product");

        int quantity = (int)Utilities.Utilities.ReadInputInt();

        string? choice = Utilities.Utilities.ReadInputString();
       
        bool isKittenFood = false;
        if (choice == "kitten food")
        {
            isKittenFood = Utilities.Utilities.CheckInput("kitten food");
        }
        Console.WriteLine("Enter weight of Product");

        int weight = (int)Utilities.Utilities.ReadInputInt();


        catFood.AddQuantity(quantity);
        catFood.SetName(name);
        catFood.SetWeightOfFood(weight);
        catFood.SetKittenFood(isKittenFood);
        catFood.AddDescription(description);
        catFood.SetPrice(price);


        Console.WriteLine($"Cat Food {JsonSerializer.Serialize(catFood)}");
    }
    private static void ChooseDogleash()
    {
        DogLeash dogLeash = new DogLeash();
        Console.WriteLine("Enter dogLeash parameters");

        Console.WriteLine("Enter Name of Product");


        string? name = Utilities.Utilities.ReadInputString();

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
        dogLeash.SetName(name);
        dogLeash.SetLength((int)length);
        dogLeash.AddDescription(description);
        dogLeash.SetMaterial(material);
        dogLeash.AddQuantity(quantity);
        dogLeash.SetName(name);
        Console.WriteLine($"Dogleash {JsonSerializer.Serialize(dogLeash)}");
    }


    public static void Main(string[] args)
    {



        string? userInput = string.Empty;
        Console.WriteLine("Welcome the Pet Store  Type 1 to enter a product, to search for a product press 8 type exit to quit");

        userInput = Utilities.Utilities.ReadInputString();

        while (userInput != null && userInput.ToLower().Trim() != "exit")
        {



            do
            {
                Console.WriteLine("Please enter the type of product press type 'dogleash' for leash ; type 'catfood for catfood");

                switch (userInput?.Trim().ToLower())
                {
                    case "dogleash":
                        ChooseDogleash();
                        break;
                    case "catfood":
                        ChooseCatFood();
                        break;
                    case "8":
                        Console.WriteLine("Please enter the type of product press type 'dogleash' for leash ; type 'catfood for catfood");
                        SearchProduct(userInput.Trim().ToLower());
                        break;


                }
                userInput = Utilities.Utilities.ReadInputString();
            } while (userInput == "1");
            continue;


        }
    }
}












