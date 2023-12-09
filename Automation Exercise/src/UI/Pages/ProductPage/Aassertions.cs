using TestAutomationPractice.Utilities;

namespace TestAutomationPractice.Pages.ProductPage
{
    partial class ProductPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - All Products", GetPageTitle());
        }
        public void AssertSaleBannerIsDisplayed()
        {
            Assert.True(bigSaleBanner.Displayed);
        }
        public void AssertAddedIconIsDisplayed()
        {
            Assert.True(successfulAddedIcon.Displayed);
        }
        public void AssertProductAddedSuccessfulTextIsDisplayed()
        {
            Assert.AreEqual(SuccessfulMessages.productAddSuccessful, productAddedSuccessfulMsg.Text);
        }
        public void AssertSearchedProductIsDisplaed(string productName)
        {
            Assert.That(allProducts.Count,Is.GreaterThan(0));
            Assert.True(SearchedProductIsDisplayed(productName));
        }
        public void AssertNonProductsAreDisplayed()
        {
            Assert.AreEqual(0,allProducts.Count);
        }
        public void AssertBrandProductCountAndDisplayedBrandProductsAreTheSame(Brands brandName)
        {
            Assert.AreEqual(GetCountOfBrandProducts(brandName), NumberOfDisplayedBrandProducts(brandName));
        }
        public void AssertProductOverlayInfoIsDisplayed(string productName)
        {
            Assert.True(GetProductOverlayInfo(productName));
        }

    }
}
