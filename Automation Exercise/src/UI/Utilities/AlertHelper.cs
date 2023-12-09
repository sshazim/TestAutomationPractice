using OpenQA.Selenium;

namespace TestAutomationPractice.Utilities
{
    public static class AlertHelper
    {
        public static void CheckForAlert(IWebDriver driver)
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}
