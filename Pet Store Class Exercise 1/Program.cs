
using System.Text.Json;
using Pet_Store_Class_Exercise_1.ProductLogic;
using Pet_Store_Class_Exercise_1.Products;
using Utilities;
#pragma warning disable CS8629
public static class PetStore
{


    private static void SearchProductByQuantity(ProductLogic productLogic)
    {
       List<Product> products = productLogic.GetOnlyInStockProducts();
       foreach (Product product in products)
       {
            Console.WriteLine(product.Name);
       }
    }
    private static void AddCatFood(ProductLogic productLogic)
    {
        Console.WriteLine("Adding Cat Food");

        CatFood catFood = new CatFood();

   
        Console.WriteLine("Enter Name of Catfood");
        var name = Utilities.InputUtilities.ReadInputString();
        Console.WriteLine("Enter Quantity of Catfood");
        var qantity = Utilities.InputUtilities.ReadInputInt();
        catFood.Name = name;
        catFood.Quantity = (int)qantity;
       //Enter rest of values TODO 
        
        productLogic.AddProduct(catFood);
        

       
    }
    private static void AddDogleash(ProductLogic productLogic)
    {
        Console.WriteLine("Adding Dog Leash");
        DogLeash dogLeash = new DogLeash();


        Console.WriteLine("Enter Name of dogleash");
        var name = Utilities.InputUtilities.ReadInputString();
        Console.WriteLine("Enter Quantity of dogleash");
        var qantity = Utilities.InputUtilities.ReadInputInt();
        dogLeash.Name = name;
        dogLeash.Quantity = (int)qantity;
        //Enter rest of values TODO 

        productLogic.AddProduct(dogLeash);

    }


    public static void Main(string[] args)
    {

        bool isRunning = true;
        Console.WriteLine("Welcome to the little petshop interface , press 1 to add dogleash,press 2 to add catfood, press 3 to search product by name, to print all products press 4,print ordered by quantity, to quite press q");
        ProductLogic productLogic = new ProductLogic();
        while (isRunning)
        {
            var userInput = Utilities.InputUtilities.ReadInputString();

            switch (userInput)
            {
                case "q":
                isRunning = false;
                Console.WriteLine("Quiting");
                break;
                case "1":
           
                AddDogleash(productLogic);
                break;
                case "2":
                
                AddCatFood(productLogic);
                break;
                case "3":
             
                    Console.WriteLine("Search product by name");
                    var name = Utilities.InputUtilities.ReadInputString();
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












