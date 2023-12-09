using OpenQA.Selenium;

namespace TestAutomationPractice.Utilities
{
    public static class YTConsentPageHelper
    {
        public static void CheckForYYConsentPage(IWebDriver driver)
        {
            driver.FindElements(By.XPath("//button[@aria-label='Accept all']")).First().Click();
        }
        
    }
}
