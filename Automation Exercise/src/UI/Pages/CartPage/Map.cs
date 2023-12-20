using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.CartPage
{
    partial class CartPage
    {
        public IList<IWebElement> productList => driver.FindElements(By.XPath("//*[@id='cart_info_table']//tbody/tr"));
        public IWebElement proceedToCheckoutButton => driver.FindElement(By.XPath("//a[@class='btn btn-default check_out']"));
        public IWebElement continueOnCardButton => driver.FindElement(By.XPath("//button[@class='btn btn-success close-checkout-modal btn-block']"));
        public IWebElement loginRegister => driver.FindElement(By.XPath("//p[contains(@href,'/login']"));
        public IWebElement emptyCartMessage => WaitAndFindElements(By.XPath("//span[@id='empty_cart']/p"));
        public IWebElement continueToProductPage => driver.FindElement(By.XPath("//*[@id='empty_cart']//a[contains(@href,'/products')]"));
        public IWebElement homeButton => driver.FindElement(By.XPath("//*[@class='breadcrumb']//*[contains(text(),'Home')]"));
        public IWebElement loginMessage => driver.FindElement(By.XPath("//*[@class='modal-body']/p[1]"));
        public IWebElement registerLoginLink => driver.FindElement(By.XPath("//*[@class='modal-body']/p[2]"));
        public IWebElement continueOnCartButton => driver.FindElement(By.XPath("//button[@data-dismiss='modal']"));
        public IWebElement proceedToCheckOutButton => driver.FindElement(By.XPath("//a[@class='btn btn-default check_out']"));
    }
}
