using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.PaymentDonePage
{
    partial class PaymentDonePage
    {
        public IWebElement orderPlaced => driver.FindElement(By.XPath("//h2[@data-qa='order-placed']"));
        public IWebElement orderConfirmedMsg => driver.FindElement(By.XPath("//*[@class='col-sm-9 col-sm-offset-1']/p"));
        public IWebElement continueButton => driver.FindElement(By.XPath("//*[@data-qa='continue-button']"));
        public IWebElement downloadInvoiceButton => driver.FindElement(By.XPath("//*[contains(@href, '/download_invoice/')]"));
    }
}
