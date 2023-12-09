using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationPractice.Utilities
{
    public class DropDownHelper
    {
        private IWebDriver driver;
        private By dropdownLocator;

        public DropDownHelper(IWebDriver driver, By dropdownLocator)
        {
            this.driver = driver;
            this.dropdownLocator = dropdownLocator;
        }
        public void SelectOptionByValue(string optionValue)
        {
            var dropdownElement = driver.FindElement(dropdownLocator);
            var select = new SelectElement(dropdownElement);
            select.SelectByValue(optionValue);
        }
    }
}
