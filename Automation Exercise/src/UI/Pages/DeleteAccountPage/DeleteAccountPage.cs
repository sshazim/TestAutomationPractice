using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.DeleteAccountPage
{
    public partial class DeleteAccountPage : BasePage
    {
        public DeleteAccountPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageURL => "https://www.automationexercise.com/delete_account";
        public void ClickOnContinue() => continueButton.Click();
    }
}
