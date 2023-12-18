using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.PaymentPage
{
    partial class PaymentPage
    {
        public IWebElement paymentTitle => driver.FindElement(By.XPath("//*[@class='step-one']/h2"));
        public IWebElement nameOnCardField => driver.FindElement(By.XPath("//input[@data-qa='name-on-card']"));
        public IWebElement cardNumberField => driver.FindElement(By.XPath("//input[@data-qa='card-number']"));
        public IWebElement cvcField => driver.FindElement(By.XPath("//input[@data-qa='cvc']"));
        public IWebElement expirationMonthField => driver.FindElement(By.XPath("//input[@data-qa='expiry-month']"));
        public IWebElement expirationYearField => driver.FindElement(By.XPath("//input[@data-qa='expiry-year']"));
        public IWebElement payOrderButton => driver.FindElement(By.XPath("//button[@data-qa='pay-button']"));
        public IWebElement successfulOrderMsg => driver.FindElement(By.XPath("//*[@class='alert-success alert']"));
        public IWebElement homeButton => driver.FindElement(By.XPath("//*[@id='cart_items']//a[contains(text(),'Home')]"));
    }
}
