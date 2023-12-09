using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.SignupPage
{
    public partial class SignupPage : BasePage
    {
        public SignupPage(IWebDriver driver) : base(driver)
        {
        }
        
        public override string PageURL => "https://www.automationexercise.com/signup";
   
        public void FillSignupForm(AccountInfo accountInfo)
        {
            if (accountInfo.Title != null)
            {
                if (accountInfo.Title == "Mr") 
                {
                    titleMrRadioButton.Click();
                   
                }
                else if(accountInfo.Title == "Mrs")
                {
                    titleMrsRadioButton.Click();
                }                 
            }
            if (accountInfo.Name != "")
            {
                nameField.SendKeys(accountInfo.Name);
            }
            if (accountInfo.Password != "")
            {
            passwordField.SendKeys(accountInfo.Password);
            }
            if (accountInfo.DayOfMonth.ToString() != null && accountInfo.MonthOfYear.ToString() != null && accountInfo.Years.ToString() != null)
            {
                dayOfBirthDropDown.SendKeys(accountInfo.DayOfMonth.ToString());
                monthOfBirthDropDown.SendKeys(accountInfo.MonthOfYear.ToString());
                yearOfBirthDropDown.SendKeys(accountInfo.Years.ToString());
            }
            if (accountInfo.FirstName != "")
            {
                firstNameField.SendKeys(accountInfo.FirstName);
            }
            if (accountInfo.LastName != "")
            {
                lastNameField.SendKeys(accountInfo.LastName);
            }
            if (accountInfo.Company != null)
            {
                companyField.SendKeys(accountInfo.Company);
            }
            if (accountInfo.Address1 != "")
            {
                addressField.SendKeys(accountInfo.Address1);
            }
            if (accountInfo.Address2 != null)
            {
                address2Field.SendKeys(accountInfo.Address2);
            }
            if (accountInfo.Country != null)
            {
            countryField.SendKeys(accountInfo.Country);
            }
            if (accountInfo.State != "")
            {
                stateField.SendKeys(accountInfo.State);
            }
            if (accountInfo.City != "")
            {
                cityField.SendKeys(accountInfo.City);
            }
            if (accountInfo.ZipCode != "")
            {
                zipCodeField.SendKeys(accountInfo.ZipCode);
            }
            if (accountInfo.MobileNumber != "")
            {
                mobileNumberField.SendKeys(accountInfo.MobileNumber);
            }
        }
        public void ClearSignupForm()
        {
            nameField.Clear();
            passwordField.Clear();
            firstNameField.Clear();
            lastNameField.Clear();
            companyField.Clear();
            addressField.Clear();
            address2Field.Clear();
            stateField.Clear();
            zipCodeField.Clear();
            mobileNumberField.Clear();
        }
        public void ClickOnCreateAccount() => createAccountButton.Click();
       public bool ValidationMessageIsDisplayed(IWebElement nameOfField)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            bool isRequired = (bool)js.ExecuteScript("return arguments[0].required;", nameOfField);
           if (isRequired)
            {
                return true;
            }
           return false;
        }
        public void CheckForNewsLetter() => newsLetterCheckbox.Click();
        public void CheckForReceiveSpecialOffers() => receiveOffersCheckbox.Click();
    }
}
