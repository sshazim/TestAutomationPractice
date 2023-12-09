using TestAutomationPractice.Utilities;

namespace TestAutomationPractice.Test_Scripts
{
    [TestFixture]
    [Order(9)]
    public class CartPageTest : BaseTest
    {
        [OneTimeSetUp]
        public void Preconditions()
        {
            suiteTest = extent.CreateTest("Cart Page Tests");
        }
        
        [Test, Order(1), Category("Test Case 12"), Category("Excercise Test")]
        public void VerifyTotalPriceOfAllAddedProductsAreCorrectWithoutLogin()
        {
            test = suiteTest.CreateNode("Test Total price of all added products are correct without login.");
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            ScrollDown(driver, 350);
            productPage.AddProductToCart("Men Tshirt");
            productPage.ContinueToShopping();
            productPage.AddProductToCart("Blue Top");
            productPage.ContinueToShopping();
            productPage.AddProductToCart("Sleeveless Dress");
            productPage.AssertProductAddedSuccessfulTextIsDisplayed();
            productPage.OpenCart();
            cartPage.AssertCorrectPageIsLoaded();
            var productNames = cartPage.GetNameOfAllAddedProducts();
            foreach (var product in productNames)
            {
                cartPage.AssertTotalPriceOfProductIsCorrect(product);
            }
        }
    }
}