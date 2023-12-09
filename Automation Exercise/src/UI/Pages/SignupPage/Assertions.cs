using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.SignupPage
{
    partial class SignupPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - Signup", GetPageTitle());
        }
        public void AssertAccountInfoTitleIsDisplayedCorectly()
        {
            Assert.AreEqual("ENTER ACCOUNT INFORMATION", accountInfoTitle.Text);
        } 
        public void AssertAddressInfoTitleIsDisplayedCorectly()
        {
            Assert.AreEqual("ADDRESS INFORMATION", addressInfoTitle.Text);
        }
        public void AssertValidationMessageIsDisplayed(IWebElement nameOfField)
        {
            Assert.True(ValidationMessageIsDisplayed(nameOfField));
        }
        public void AssertAllRequiredFieldAreFilled()
        {
            Assert.True(nameField.GetAttribute("value")!=null,"Name field is not empty.");
            Assert.True(emailField.GetAttribute("value")!=null, "Email field is not empty.");
            Assert.True(passwordField.GetAttribute("value")!=null, "Password field is not empty.");
            Assert.True(firstNameField.GetAttribute("value")!=null, "FirstName field is not empty.");
            Assert.True(lastNameField.GetAttribute("value")!=null, "LastName field is not empty.");
            Assert.True(addressField.GetAttribute("value")!=null, "Address field is not empty.");
            Assert.True(countryField.GetAttribute("value")!=null, "Country field is not empty.");
            Assert.True(stateField.GetAttribute("value")!=null, "State field is not empty.");
            Assert.True(zipCodeField.GetAttribute("value")!=null, "Zipcode field is not empty.");
            Assert.True(mobileNumberField.GetAttribute("value")!=null, "MobileNumber field is not empty.");
        }
       
    }
}
