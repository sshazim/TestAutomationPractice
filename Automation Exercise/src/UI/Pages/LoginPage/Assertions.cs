using TestAutomationPractice.Utilities;
using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.LoginPage
{
    partial class LoginPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - Signup / Login", GetPageTitle());
        }
        public void AssertCorrectLoginFormTitleIsDisplayed()
        {
            Assert.AreEqual("Login to your account",loginFormTitle.Text);
        }
        public void AssertLoginEmailAddressFieldIsDisplayed()
        {
            Assert.True(loginEmailField.Displayed);
        }
        public void AssertLoginPasswordFieldIsDisplayed() 
        {
            Assert.True(loginPasswordField.Displayed);
        }
        public void AssertLoginButtonIsDisplayed()
        {
            Assert.True(loginButton.Displayed);
        }  
        public void AssertCorrectSignupFormTitleIsDisplayed()
        {
            Assert.AreEqual("New User Signup!", signupFormTitle.Text);
        }
        public void AssertSignupNameFieldIsDisplayed()
        {
            Assert.True(signupNameField.Displayed);
        }
        public void AssertSignupEmailFieldIsDisplayed()
        {
            Assert.True(signupEmailField.Displayed);
        }
        public void AssertSignupButtonIsDisplayed()
        {
            Assert.True(signupButton.Displayed);
        }
        public void AssertErrorEmptyFieldMessageIsDisplayed(IWebElement field)
        {
            Assert.AreEqual(ErrorMessages.emptyField, ValidationMessage(field));
        }
        public void AssertIncorrectInputDataMessageIsDisplayed()
        {
            Assert.AreEqual(ErrorMessages.incorrectData,incorrectDataMessage.Text);
        }
        public void AssertErrorInvalidEmailAddressMessageIsDisplayed(IWebElement field,string email)
        {
            Assert.AreEqual(string.Format(ErrorMessages.incorrectEmailAddress,email), ValidationMessage(field));
        }
        public void AssertErrorIncompleteEmailAddressMessageIsDisplayed(IWebElement field, string email)
        {
            Assert.AreEqual(string.Format(ErrorMessages.incompleteEmailAddress, email), ValidationMessage(field));
        }
        public void AssertErrorEmailAddressAlreadyExistMessageIsDisplayed()
        {
            Assert.AreEqual(ErrorMessages.emailAddressAlreadyExist, emailAddressAlreadyExistMsg.Text);
        }
        
    }
}
