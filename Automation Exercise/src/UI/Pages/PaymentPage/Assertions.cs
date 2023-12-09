using TestAutomationPractice.Utilities;
using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.PaymentPage
{
    partial class PaymentPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - Payment", GetPageTitle());
        }
        public void AssertCorrectPaymentTitleIsDisplayed()
        {
            Assert.AreEqual("Payment", paymentTitle.Text);
        }
        public void AssertCorrectSuccessfulOrderMessageIsDisplayed()
        {
            Assert.AreEqual(SuccessfulMessages.successfulOrder, successfulOrderMsg.Text);
        }
        public void AssertCorrectPaymentFormIsDisplayed()
        {
            Assert.True(nameOnCardField.Displayed);
            Assert.True(cardNumberField.Displayed);
            Assert.True(cvcField.Displayed);
            Assert.True(expirationMonthField.Displayed);
            Assert.True(expirationYearField.Displayed);
            Assert.True(payOrderButton.Displayed);
        }
        public void AssertErrorEmptyFieldMessageIsDisplayed(IWebElement field)
        {
            Assert.AreEqual(ErrorMessages.emptyField, ValidationMessage(field));
        }
    }
}
