using TestAutomationPractice.Utilities;
using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.ContactUsPage
{
    partial class ContactUsPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - Contact Us", GetPageTitle());
        }
        public void AssertContactUsFormTitleIsDisplayedCorectly()
        {
            Assert.AreEqual("CONTACT US", contactUsFormTitle.Text);
        }
        public void AssertFeedbackTitleIsDisplayedCorrectly()
        {
            Assert.AreEqual("FEEDBACK FOR US",feedbackTitle.Text);
        }
        public void AssertFeedbackTextInfoIsDisplayedCorrectly()
        {
            Assert.AreEqual(Constants.feedbackInfoText, feedbackTextInfo.Text);
        }
        public void AssertContactFormFieldsAreDisplayed()
        {
            Assert.True(nameField.Displayed);
            Assert.True(emailField.Displayed);
            Assert.True(subjectField.Displayed);
            Assert.True(messagetField.Displayed);
            Assert.True(chooseFileButton.Displayed);
            Assert.True(submitButton.Displayed);
        }
        public void AssertSuccessfulMessageIsDisplayed()
        {
            Assert.True(successfulMessage.Displayed);
            Assert.AreEqual(SuccessfulMessages.contactUsSuccessfulMessage, successfulMessage.Text);
        }
        public void AssertHomeButtonIsDisplayed()
        {
            Assert.True(homeButton.Displayed);
        }
        public void AssertErrorEmptyFieldMessageIsDisplayed(IWebElement field)
        {
            Assert.AreEqual(ErrorMessages.emptyField, ValidationMessage(field));
        }
        public void AssertErrorInvalidEmailAddressMessageIsDisplayed(IWebElement field, string email)
        {
            Assert.AreEqual(string.Format(ErrorMessages.incorrectEmailAddress, email),ValidationMessage(field));
        }
        public void AssertErrorIncompleteEmailAddressMessageIsDisplayed(IWebElement field, string email)
        {
            Assert.AreEqual(string.Format(ErrorMessages.incompleteEmailAddress, email), ValidationMessage(field));
        }

    }
}
