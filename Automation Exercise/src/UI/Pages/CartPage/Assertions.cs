using TestAutomationPractice.Utilities;

namespace TestAutomationPractice.Pages.CartPage
{
    partial class CartPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - Checkout", GetPageTitle());
        }
        public void AssertProcessToCheckoutButtonIsDisplayed()
        {
            Assert.True(proceedToCheckoutButton.Displayed);
        }
        public void AssertCorrectLoginToAccoutMessageIsDisplayed()
        {
            Assert.AreEqual(SuccessfulMessages.loginToContinueToCheckout, loginMessage.Text);
        }
        public void AssertProductListIsNotEmpty()
        {
            Assert.Greater(productList.Count,0);
        }
        public void AssertProductIsRemoved(string productName)
        {
            Assert.True(CheckProductRemoval(productName));
        }
        public void AssertCorrectEmptyCartMessageIsDisplayed()
        {
            Assert.True(emptyCartMessage.Displayed);
            Assert.AreEqual(Constants.emptyCartText, emptyCartMessage.Text);
        }
        public void AssertProductIsAddedToCart(string productName)
        {
            Assert.True(CheckProductIsAddedToCart(productName));
        }
        public void AssertTotalPriceOfProductIsCorrect(string productName)
        {
            int actualPrice = GetTotalPriceOfProduct(productName);
            int expectedPrice = CalculateTotalPriceForProduct(productName);
            TestContext.WriteLine($"Expected Price of {productName} was {expectedPrice}, and the actual value reflected on webpage was {actualPrice}");
            Assert.AreEqual(actualPrice, expectedPrice);
        }
        public void AssertCorrectProductQuantity(string productName,int quantity)
        {
            Assert.AreEqual(quantity, GetProductQuantity(productName));
        }
    }
}
