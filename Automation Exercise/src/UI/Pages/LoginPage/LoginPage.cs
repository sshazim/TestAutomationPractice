using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.LoginPage
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageURL => "https://www.automationexercise.com/login";
        public void FillSingupForm(string name, string email)
        {
            signupNameField.SendKeys(name);
            signupEmailField.SendKeys(email);
            
        }
        public void ClickOnSignupButton() => signupButton.Click();
        public void FillLoginForm(string email, string password)
        {
            loginEmailField.SendKeys(email);
            loginPasswordField.SendKeys(password);
        }
        public void ClickOnLoginButton() => loginButton.Click();
        public string ValidationMessage(IWebElement field) => field.GetAttribute("validationMessage");
    }
}
