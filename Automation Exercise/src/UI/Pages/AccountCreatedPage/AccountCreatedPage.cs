using OpenQA.Selenium;


namespace TestAutomationPractice.Pages.AccountCreatedPage
{
    public partial class AccountCreatedPage : BasePage
    {
        public AccountCreatedPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageURL => "https://www.automationexercise.com/account_created";
        
        public void ClickOnContinue() => continueButton.Click();
    }
}
