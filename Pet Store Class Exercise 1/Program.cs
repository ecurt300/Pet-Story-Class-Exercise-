
using System.Text.Json;
using Pet_Store_Class_Exercise_1;
using Utilities;
#pragma warning disable CS8629
public static class PetStore
{

    //Untested refactor will probably workss
    private static void SearchProductByQuantity(ProductLogic productLogic)
    {
       List<string> products = productLogic.GetOnlyInStockProducts();
       foreach (string product in products)
       {
            Console.WriteLine(product);
        }
    }
    private static void AddCatFood(ProductLogic productLogic)
    {
        Console.WriteLine("Adding Cat Food");

        CatFood catFood = new CatFood();

   
        Console.WriteLine("Enter Name of Catfood");
        var name = Utilities.Utilities.ReadInputString();
        Console.WriteLine("Enter Quantity of Catfood");
        var qantity = Utilities.Utilities.ReadInputInt();
        catFood.Name = name;
        catFood.Quantity = (int)qantity;
       //Enter rest of values
        
        productLogic.AddProduct(catFood);

       
    }
    private static void AddDogleash(ProductLogic productLogic)
    {
        Console.WriteLine("Adding Dog Leash");
        DogLeash dogLeash = new DogLeash();


        Console.WriteLine("Enter Name of dogleash");
        var name = Utilities.Utilities.ReadInputString();
        Console.WriteLine("Enter Quantity of dogleash");
        var qantity = Utilities.Utilities.ReadInputInt();
        dogLeash.Name = name;
        dogLeash.Quantity = (int)qantity;
        //Enter rest of values

        productLogic.AddProduct(dogLeash);

    }


    public static void Main(string[] args)
    {

        bool isRunning = true;
        Console.WriteLine("Welcome to the little petshop interface , press 1 to add dogleash,press 2 to add catfood, press 3 to search product by name, to print all products press 4, to quite press q");
        ProductLogic productLogic = new ProductLogic();
        while (isRunning)
        {
            var userInput = Utilities.Utilities.ReadInputString();

            switch (userInput)
            {
                case "q":
                isRunning = false;
                Console.WriteLine("Quiting");
                break;
                case "1":
                    //productLogic add product dogleash
                AddDogleash(productLogic);
                break;
                case "2":
                //productLogic add product catfood
                AddCatFood(productLogic);
                break;
                case "3":
                    //SearchProductByName
                    Console.WriteLine("Search product by name");
                    var name = Utilities.Utilities.ReadInputString();
                    productLogic.GetProductByName(name);
                    break;
                case "4":
                    Console.WriteLine("Printing out all products");
                    productLogic.GetAllProducts();
                    break;
                case "5":
                    Console.WriteLine("printing ordered by quantity");
                    SearchProductByQuantity(productLogic);
                    break;
               
               

            }
        }

    }
}












