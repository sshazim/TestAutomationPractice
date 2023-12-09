using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.CheckoutPage
{
    partial class CheckoutPage
    {
        public IWebElement addressFormTitle => driver.FindElement(By.XPath("//*[@class='step-one']/h2[contains(text(),'Address')]"));
        public IWebElement deliveryAddress => driver.FindElement(By.XPath("//*[@id='address_delivery']/li[1]"));
        public IWebElement deliveryFirstLastNameInfo => driver.FindElement(By.XPath("//*[@id='address_delivery']/li[2]"));
        public IWebElement deliveryCompanyInfo => driver.FindElement(By.XPath("//*[@id='address_delivery']/li[3]"));
        public IWebElement deliveryAddress1Info => driver.FindElement(By.XPath("//*[@id='address_delivery']/li[4]"));
        public IWebElement deliveryAddress2Info => driver.FindElement(By.XPath("//*[@id='address_delivery']/li[5]"));
        public IWebElement deliveryCityNameStateZipCode => driver.FindElement(By.XPath("//*[@id='address_delivery']/li[6]"));
        public IWebElement deliveryCountryInfo => driver.FindElement(By.XPath("//*[@id='address_delivery']/li[7]"));
        public IWebElement deliveryPhoneNumberInfo => driver.FindElement(By.XPath("//*[@id='address_delivery']/li[8]"));
        public IWebElement billingAddress => driver.FindElement(By.XPath("//*[@id='address_invoice']/li[1]"));
        public IWebElement billingFirstLastNameInfo => driver.FindElement(By.XPath("//*[@id='address_invoice']/li[2]"));
        public IWebElement billingCompanyInfo => driver.FindElement(By.XPath("//*[@id='address_invoice']/li[3]"));
        public IWebElement billingAddress1Info => driver.FindElement(By.XPath("//*[@id='address_invoice']/li[4]"));
        public IWebElement billingAddress2Info => driver.FindElement(By.XPath("//*[@id='address_invoice']/li[5]"));
        public IWebElement billingCityNameStateZipCode => driver.FindElement(By.XPath("//*[@id='address_invoice']/li[6]"));
        public IWebElement billingCountryInfo => driver.FindElement(By.XPath("//*[@id='address_invoice']/li[7]"));
        public IWebElement billingPhoneNumberInfo => driver.FindElement(By.XPath("//*[@id='address_invoice']/li[8]"));
        public IList<IWebElement> orderProducts => driver.FindElements(By.XPath("//*[@id='cart_info']//tbody"));
        public IWebElement orderTotalAmount => orderProducts[orderProducts.Count - 1].FindElement(By.XPath("//*[@class='cart_total_price']"));
        public IList<IWebElement> orderProductsName => driver.FindElements(By.XPath("//*[@class='cart_description']/h4"));
        public IWebElement commentArea => driver.FindElement(By.XPath("//textarea[@class='form-control']"));
        public IWebElement placeOrderButton => driver.FindElement(By.XPath("//*[@href='/payment']"));
        public IWebElement homeButton => driver.FindElement(By.XPath("//*[@id='cart_items']//a[contains(text(),'Home')]"));
    }
}
