using TestAutomationPractice.src.UI.TestData;
using TestAutomationPractice.Utilities;

namespace TestAutomationPractice.Test_Scripts
{
    [TestFixture]
    [Order(8)]
    public class LoginPageTest : BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            suiteTest = extent.CreateTest("Login Page Tests");
        }
        [SetUp]
        public void Setup()
        {

            loginPage.Open();
            loginPage.AssertCorrectPageIsLoaded();
            loginPage.AssertCorrectLoginFormTitleIsDisplayed();
        }

        [Test, Order(2), Category("Test Case 2"), Category("Excercise Test")]
        [TestCaseSource(typeof(LoginTestCases), nameof(LoginTestCases.LoginWithValidEmailOrPassowrd))]
        public void VerifyUserLoginWithValidData(string email, string password)
        {
            test = suiteTest.CreateNode("Test User Login With Valid Credentials");
            loginPage.FillLoginForm(Constants.email, Constants.password);
            loginPage.ClickOnLoginButton();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertUserIsLogin();
            homePage.Logout();
        }

        [Test, Order(2), Category("Test Case 3"), Category("Excercise Test")]
        [TestCaseSource(typeof(LoginTestCases), nameof(LoginTestCases.LoginWithInvalidEmailOrPassowrd))]
        public void VerifyLoginWithInvalidEmailOrPassword(string email, string password)
        {
            test = suiteTest.CreateNode("Test User Login With Invalid Credentials");
            loginPage.FillLoginForm(email, password);
            loginPage.ClickOnLoginButton();
            switch (email)
            {
                case "incorrectEmail":
                    loginPage.AssertErrorInvalidEmailAddressMessageIsDisplayed(loginPage.loginEmailField, email);
                    break;
                case "incorrectEmail@":
                    loginPage.AssertErrorIncompleteEmailAddressMessageIsDisplayed(loginPage.loginEmailField, email);
                    break;
                case Constants.email:
                    loginPage.AssertIncorrectInputDataMessageIsDisplayed();
                    break;
            };
        }
    }
}
