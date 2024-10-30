// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using System.Text.Json;
using Pet_Store_Class_Exercise_1;

    public static class PetStore
    {

     private static void EnterDogFood(ProductLogic productLogic,string? userInput)
     {
        if( productLogic.GetDogLeashByName("") != null)
        {
            Console.WriteLine("Enter Dog Leash Name");
            productLogic.GetDogLeashByName("").Name = userInput;
            Console.WriteLine("Enter Dog Leash description");
            
        }
     }
    private static void EnterCatFood(ProductLogic productLogic, string? userInput)
    {
        if (productLogic.GetCatFoodByName("") != null)
        {
            productLogic.GetCatFoodByName("").Name = userInput;
        }
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

        string? userInput = string.Empty;
        Console.WriteLine("Welcome the Pet Store  Type 1 to enter a product, to search for a product press 8 type exit to quit");
       
        userInput = Console.ReadLine();
        ProductLogic productLogic = new ProductLogic();
        while ( userInput != null && userInput.ToLower().Trim() != "exit")
        {



          

            try
            {
              if(userInput == "1")
                {
                    Console.WriteLine("Please enter the type of product press type 'dogleash' for leash ; type 'catfood for catfood");
                }
                if(userInput.Trim().ToLower() == "dogleash")
                {
                    DogLeash dogLeash = new DogLeash();
                    productLogic.AddProduct(dogLeash);
                    Console.WriteLine("dogLeash Selected enter dogleash parameters");
                }
                else if (userInput.Trim().ToLower() == "catfood")
                {
                    CatFood catFood = new CatFood();
                    productLogic.AddProduct(catFood);
                    Console.WriteLine("Catfood selected enter catfood parameters");
                }
                Console.WriteLine("Enter dogl to add paremeters");
                
                userInput = Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }

        }
      

    }
}

