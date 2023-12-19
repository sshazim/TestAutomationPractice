using TestAutomationPractice.Pages.SignupPage;
using TestAutomationPractice.src.API.Responses.User;
using TestAutomationPractice.src.UI.TestData;
using TestAutomationPractice.Utilities;

namespace TestAutomationPractice.Test_Scripts
{
    [TestFixture]
    [Order(11)]
    public class SignupPageTest : BaseTest
    {
        private AccountInfo accountInfo;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            
            suiteTest = extent.CreateTest("Signup Page Tests");
        }
        [SetUp]
        public void Preconditions()
        {       
            loginPage.Open();
            loginPage.AssertCorrectPageIsLoaded();
            loginPage.AssertCorrectSignupFormTitleIsDisplayed();           
        }
               
        [Test, Order(1), Category("Test Case 1"), Category("Excercise Test")]
        public void VerifyRegisterNewUserWithFilledAllFields()
        {
            test = suiteTest.CreateNode("Test Register User With All Credentials");
            static string GenerateRandomEmail()
            {
                string[] domains = { "example.com", "test.com", "random.org" };
                Random random = new Random();

                string username = $"user{random.Next(100000)}";
                string domain = domains[random.Next(domains.Length)];

                return $"{username}@{domain}";
            }
            loginPage.FillSingupForm(Constants.name, GenerateRandomEmail());
            loginPage.ClickOnSignupButton();
            signupPage.AssertCorrectPageIsLoaded();          
            accountInfo = new AccountInfo()
            {
                Name = Constants.name,
                Title = Constants.title,
                Password = Constants.password,
                DayOfMonth = DayOfMonth.Day22,
                MonthOfYear = MonthOfYear.July,
                Years = Years.Year1999,
                FirstName = Constants.firstName,
                LastName = Constants.lastName,
                Company = Constants.companyName,
                Address1 = Constants.firstAddress,
                Address2 = Constants.secondAddress,
                Country = Constants.country,
                State = Constants.state,
                City = Constants.city,
                ZipCode = Constants.zipCode,
                MobileNumber = Constants.mobileNumber
            };
            ScrollDown(driver, 250);
            signupPage.CheckForNewsLetter();
            signupPage.CheckForReceiveSpecialOffers();
            signupPage.FillSignupForm(accountInfo);
            ScrollToBottom(driver);
            signupPage.ClickOnCreateAccount();
            accountCreatedPage.AssertCorrectPageIsLoaded();
            accountCreatedPage.AssertAccountCreatedTitleIsDisplayedCorrectly();
            accountCreatedPage.AssertFirstSuccessfullMessageIsDisplayedCorrectly();
            accountCreatedPage.AssertSecondSuccessfullMessageIsDisplayedCorrectly();
            accountCreatedPage.ClickOnContinue();
            AdverticeHelper.CheckForAdvertice(driver);
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertUserIsLogin();
        }
        [Test, Order(2), Category("Test Case 1"), Category("Excercise Test")]
        public void RegisterUserWithExistingEmail()
        {
            test = suiteTest.CreateNode("Validate sign up with existing email id");
            loginPage.FillSingupForm(Constants.name, Constants.email);
            loginPage.ClickOnSignupButton();
            signupPage.AssertDuplicateEmailMessage();
        }
    }
}
