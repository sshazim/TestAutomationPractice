using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestAutomationPractice.Pages
{
    public abstract class BasePage
    {
        private int elementsTimeout = 10;
        protected IWebDriver driver { get; set; }
        protected WebDriverWait waitDriver { get; set; }
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            waitDriver = new WebDriverWait(driver, TimeSpan.FromSeconds(elementsTimeout));
        }
        public abstract string PageURL { get; }
        public void Open() => driver.Navigate().GoToUrl(PageURL);
        public string GetPageTitle() => driver.Title;
        public string GetPageUrl() => driver.Url;
        //Method that wait element to be visible then located him and
        //if isn't visible then catch the exception
        protected IWebElement WaitAndFindElements(By locator)
        {
            try
            {
                return waitDriver.Until(ExpectedConditions.ElementIsVisible(locator));
            }
            catch (NoSuchElementException ex)
            {
                throw new NoSuchElementException($"Element not found: {locator}, {ex}");
            }
            catch (WebDriverException ex)
            {
                throw new WebDriverException($"WebDriverException occurred: {ex.Message}, {ex}");
            }
        }
        public static void HoverOverElement(IWebDriver driver, IWebElement element)
        {
            // Move the mouse cursor to the element without clicking
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Perform();
        }
        protected string ValidationMessage(IWebElement field) => field.GetAttribute("validationMessage");
    }
}
