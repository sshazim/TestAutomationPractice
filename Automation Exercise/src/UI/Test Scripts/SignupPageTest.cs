using TestAutomationPractice.Pages.SignupPage;
using TestAutomationPractice.src.UI.TestData;
using TestAutomationPractice.Utilities;

namespace TestAutomationPractice.Test_Scripts
{
    [TestFixture]
    [Order(11)]
    public class SignupPageTest : BaseTest
    {
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
            loginPage.FillSingupForm(Constants.name, Constants.email);
            loginPage.ClickOnSignupButton();
            signupPage.SignUpWithEmail(Constants.email);
            loginPage.ClearEmailInSignUpPage();
            loginPage.FillSingupForm(Constants.name, signupPage.SignUpWithEmail(Constants.email));
            loginPage.ClickOnSignupButton();


            signupPage.AssertCorrectPageIsLoaded();
        }
        private AccountInfo accountInfo;
        
        [Test, Order(1), Category("Test Case 1"), Category("Excercise Test")]
        public void VerifyRegisterNewUserWithFilledAllFields()
        {
            test = suiteTest.CreateNode("Test Register User With All Credentials");
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
    }
}
