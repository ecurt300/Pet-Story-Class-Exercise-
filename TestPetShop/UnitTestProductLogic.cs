
using Pet_Store_Class_Exercise_1.ProductLogic;
using Pet_Store_Class_Exercise_1.Products;
using Microsoft.Extensions.DependencyInjection;
namespace TestPetShop
{
    [TestClass]
    public class UnitTestProductLogic
    {
        /*
         * Reminder to myself and instructors-> 
         * I don't usually utilize Unit Tests during my regular programming sessions or homework. That is because I 
         * I code games in my spare time and are so used to running complex moving systems (simple physics, objects always in motion, dynamic calculations etc)
         * However, I do write test projects testing a piece of logic or feature to make sure it works. I decided to make a unit test project within 
         * the Pet Store Solution since the logic isn't real time.
         * 
         * 
         */

        ServiceProvider serviceProviderCollection = (ServiceProvider)TestCreateServiceCollection();

        public static IServiceProvider TestCreateServiceCollection()
        {

            IServiceCollection services = new ServiceCollection();

            services.AddTransient<IProductLogic, ProductLogic>();




            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void ProductLogicTest()
        {

            Product actualProduct = new Product();
            actualProduct.Name = "Dummy";
            ProductLogic productLogic = new ProductLogic();

            productLogic.AddProduct(actualProduct);

            Product? getProduct = productLogic.GetProductByName("Dummy");

            Assert.AreEqual(actualProduct, getProduct);



        }

        [TestMethod]
        public void ProductLogicTest2()
        {

            Product actualProduct = new Product();
            actualProduct.Name = "Dummy";
            ProductLogic? productLogic = serviceProviderCollection.GetService<IProductLogic>() as ProductLogic;

            productLogic?.AddProduct(actualProduct);

            Product? getProduct = productLogic?.GetProductByName("Dummy");

            Assert.AreEqual(actualProduct, getProduct);



        }
    }
}