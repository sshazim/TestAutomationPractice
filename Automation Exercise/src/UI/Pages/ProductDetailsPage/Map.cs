using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.ProductDetailsPage
{
    partial class ProductDetailsPage
    {
        public IWebElement productPicture => driver.FindElement(By.XPath("//*[contains(@src,'/get_product_picture/')]"));
        public IWebElement productName => driver.FindElement(By.XPath("//*[@class='product-information']//h2"));  
        public IWebElement productPrice => driver.FindElement(By.XPath("//*[contains(text(),'Rs.')]"));
        public IWebElement productQuantity => driver.FindElement(By.XPath("//*[@id='quantity']"));
        public IWebElement addToCartButton => driver.FindElement(By.XPath("//button[@type='button']"));
        public IWebElement avaliableInfo => driver.FindElement(By.XPath("//*[@class='product-information']//p[2]"));
        public IWebElement conditionInfo => WaitAndFindElements(By.XPath("//*[@class='product-information']//p[3]"));
        public IWebElement brandInfo => WaitAndFindElements(By.XPath("//*[@class='product-information']//p[4]"));
        public IWebElement reviewFormTitle => driver.FindElement(By.XPath("//*[@href='#reviews']"));
        public IWebElement nameField => driver.FindElement(By.XPath("//*[@id='name']"));
        public IWebElement emailAddressField => driver.FindElement(By.XPath("//*[@id='email']"));
        public IWebElement reviewField => driver.FindElement(By.XPath("//*[@id='review']"));
        public IWebElement submitButton => driver.FindElement(By.XPath("//*[@id='button-review']"));
        public IWebElement successfulReviewSubmit => WaitAndFindElements(By.XPath("//*[@class='alert-success alert']"));
        public IWebElement successfulAddedIcon => WaitAndFindElements(By.XPath("//i[@class='material-icons']"));
        public IWebElement productAddedSuccessfulMsg => WaitAndFindElements(By.XPath("//p[@class='text-center'][1]"));
        public IWebElement viewCart => WaitAndFindElements(By.XPath("//p[@class='text-center'][2]/a"));
        public IWebElement continueShoppingButton => WaitAndFindElements(By.XPath("//button[@data-dismiss='modal']"));
    }
}
