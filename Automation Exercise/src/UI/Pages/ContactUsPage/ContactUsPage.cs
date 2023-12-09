using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.ContactUsPage
{
    public partial class ContactUsPage : BasePage
    {
        public ContactUsPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageURL => "https://www.automationexercise.com/contact_us";
        public void FillContactUsForm(ContactUsForm form)
        {
            nameField.SendKeys(form.Name);
            emailField.SendKeys(form.Email);
            subjectField.SendKeys(form.Subject);
            messagetField.SendKeys(form.Message);
           // chooseFileButton.SendKeys(form.ChoosenFile);
        }
        public void ClickOnHomeButton() => homeButton.Click();
        public void SubmiteForm() => submitButton.Click();
    }
}
