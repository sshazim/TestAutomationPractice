using System.Text;
using System.Text.RegularExpressions;
using TestAutomationPractice.Pages.AccountCreatedPage;
using TestAutomationPractice.Pages.CartPage;
using TestAutomationPractice.Pages.CheckoutPage;
using TestAutomationPractice.Pages.ContactUsPage;
using TestAutomationPractice.Pages.DeleteAccountPage;
using TestAutomationPractice.Pages.HomePage;
using TestAutomationPractice.Pages.LoginPage;
using TestAutomationPractice.Pages.PaymentDonePage;
using TestAutomationPractice.Pages.PaymentPage;
using TestAutomationPractice.Pages.ProductDetailsPage;
using TestAutomationPractice.Pages.ProductPage;
using TestAutomationPractice.Pages.SignupPage;
using TestAutomationPractice.Utilities;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationPractice.Test_Scripts
{
    public abstract class BaseTest
    {
        protected IWebDriver driver;
        protected HomePage homePage;
        protected ProductPage productPage;
        protected ProductDetailsPage productDetailsPage;
        protected CartPage cartPage;
        protected PaymentPage paymentPage;
        protected PaymentDonePage paymentDonePage;
        protected CheckoutPage checkoutPage;
        protected LoginPage loginPage;
        protected SignupPage signupPage;
        protected AccountCreatedPage accountCreatedPage;
        protected DeleteAccountPage deleteAccountPage;
        protected ContactUsPage contactUsPage;
        protected static ExtentReports extent;
        protected ExtentTest suiteTest;
        protected ExtentTest test;
        private BrowserType browserType;
        [OneTimeSetUp]
        public void BaseOneTimeSetUp()
        {
            browserType = BrowserType.Chrome; // Change this to the desired browser
            driver = DriverHelper.Start(browserType); //To use headless mode uncomment it in this method.
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            productPage = new ProductPage(driver);
            productDetailsPage = new ProductDetailsPage(driver);
            cartPage = new CartPage(driver);
            paymentPage = new PaymentPage(driver);
            paymentDonePage = new PaymentDonePage(driver);
            checkoutPage = new CheckoutPage(driver);
            loginPage = new LoginPage(driver);
            signupPage = new SignupPage(driver);
            accountCreatedPage = new AccountCreatedPage(driver);
            deleteAccountPage = new DeleteAccountPage(driver);
            contactUsPage = new ContactUsPage(driver);
            if (extent == null)
            {
                var htmlReporter = new ExtentHtmlReporter(@"..\..\..\src\Common\Test Results\UI\results.html");
                htmlReporter.Config.DocumentTitle = "Test Automation Report";
                htmlReporter.Config.Encoding = "UTF-8";
                htmlReporter.Config.Theme = Theme.Dark;
                extent = new ExtentReports();
                extent.AddSystemInfo("OS", Environment.OSVersion.ToString());
                extent.AddSystemInfo("Browser", $"{browserType} ver.{GetCurrentBrowserVersion()}");
                extent.AddSystemInfo("Framework", "NUnit ver.3.13.3 <br>SeleniumWebDriver ver.4.11.0");
                extent.AddSystemInfo(".NET Version", Environment.Version.ToString());
                extent.AttachReporter(htmlReporter);
            }
        }
        private string GetCurrentBrowserVersion()
        {
            string pattern;
            string browserVersion = ((IJavaScriptExecutor)driver).ExecuteScript("return navigator.userAgent;").ToString();
            if (browserType == BrowserType.Firefox)
            {
                pattern = @"Firefox\/(\d+\.\d+)";
            }
            else
            {
                pattern = @"([\d\.]){13,14}";
            }
            Match match = Regex.Match(browserVersion, pattern);
            if (match.Success && match.Groups.Count > 1 && browserType != BrowserType.Firefox)
            {
                return match.Groups[0].Value;
            }
            return match.Groups[1].Value;
        }
        protected void UserLogin()
        {
            loginPage.Open();
            loginPage.FillLoginForm(Constants.email, Constants.password);
            loginPage.ClickOnLoginButton();
        }
        protected static void ScrollToTop(IWebDriver driver)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("window.scrollTo(0, -document.body.scrollHeight)");

        }
        protected static void ScrollToBottom(IWebDriver driver)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }
        protected static void ScrollDown(IWebDriver driver, int pixels)
        {
            //Scrolling down  to avoid ads.
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript($"window.scrollBy(0, {pixels});");
        }
        protected static void BackToPreviusPage(IWebDriver driver)
        {
            //Using this method because in some cases every time ads are different.
            if (driver.Url.EndsWith("#google_vignette"))
            {
                driver.Navigate().Back();
                driver.Navigate().Back();
            }
        }
        public string CaptureScreenshot()
        {
            string dateTimeFormatted = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            string screenshotFileName = $"{TestContext.CurrentContext.Test.Name}-{dateTimeFormatted}.png";
            string screenshotFilePath = $@"..\..\..\src\Common\Test Results\UI\{screenshotFileName}";

            // Capture the screenshot and save it to the specified file path
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);

            return screenshotFileName;
        }

        [TearDown]
        public void AfterTest()
        {
            // Get the test result and update the test status
            var message = TestContext.CurrentContext.Result.Message;
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            if (status == TestStatus.Failed)
            {
                string formattedErrorMessage = $"Test failed.<br>{message}";

                // Capture a screenshot and attach it to the test report
                MediaEntityModelProvider mediaModel = MediaEntityBuilder.CreateScreenCaptureFromPath(CaptureScreenshot()).Build();
                test.Fail(formattedErrorMessage, mediaModel);

            }
            else if (status == TestStatus.Passed)
            {
                test.Pass($"Test has passed.<br>{message}");
            }
            else if (status == TestStatus.Skipped)
            {
                test.Skip($"Test skipped.<br>{message}");
            }
            extent.Flush();
        }
        [OneTimeTearDown]
        public void Dispose()
        {
            extent.Flush(); //End report
            driver.Dispose();
        }
    }
}
