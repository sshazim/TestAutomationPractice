using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.DeleteAccountPage
{
    partial class DeleteAccountPage
    {
        public IWebElement accountDeleteMsg => driver.FindElement(By.XPath("//h2[@data-qa='account-deleted']"));
        public IWebElement continueButton => driver.FindElement(By.XPath("//a[@data-qa='continue-button']"));
        public IWebElement firstAccountDeletedSuccessfullMsg => driver.FindElement(By.XPath("//*[contains(text(), 'deleted!')]"));
        public IWebElement secondAccountDeletedSuccessfullMsg => driver.FindElement(By.XPath("//*[@class='col-sm-9 col-sm-offset-1']/p[2]"));
    }
}
