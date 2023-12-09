using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.ContactUsPage
{
    partial class ContactUsPage
    {

        public IWebElement contactUsFormTitle => driver.FindElement(By.XPath("//h2[@class='title text-center']"));
        public IWebElement nameField => driver.FindElement(By.XPath("//input[@data-qa='name']"));
        public IWebElement emailField => driver.FindElement(By.XPath("//input[@data-qa='email']"));
        public IWebElement subjectField => driver.FindElement(By.XPath("//input[@data-qa='subject']"));
        public IWebElement messagetField => driver.FindElement(By.XPath("//textarea[@data-qa='message']"));
        public IWebElement chooseFileButton => driver.FindElement(By.XPath("//input[@name='upload_file']"));
        public IWebElement submitButton => driver.FindElement(By.XPath("//input[@data-qa='submit-button']"));
        public IWebElement successfulMessage => driver.FindElement(By.XPath("//*[@class='status alert alert-success']"));
        public IWebElement homeButton => driver.FindElement(By.XPath("//a[@class='btn btn-success']"));
        public IWebElement feedbackTitle => driver.FindElement(By.XPath("//*[@class='contact-info']/h2"));
        public IWebElement feedbackTextInfo => driver.FindElement(By.XPath("//*[@class='contact-info']/address"));
    }
}
