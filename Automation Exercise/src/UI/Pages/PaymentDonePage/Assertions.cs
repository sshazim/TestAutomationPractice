using TestAutomationPractice.Utilities;

namespace TestAutomationPractice.Pages.PaymentDonePage
{
    partial class PaymentDonePage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - Order Placed", GetPageTitle());
        }
        public void AssertCorrectOrderTitleIsDisplayed()
        {
            Assert.AreEqual("ORDER PLACED!", orderPlaced.Text);
        }
        public void AssertOrderConfirmedMessageIsDisplayedCorrectly()
        {
            Assert.AreEqual(SuccessfulMessages.orderConfirmed, orderConfirmedMsg.Text);
        }
        public void AssertFileDownloadSuccessful()
        {
            Thread.Sleep(500);
            Assert.True(File.Exists(Constants.downloadedFilePath), "Downloaded file does exist.");
        }
        public void AssertFileContentIsCorrectly()
        {
            Assert.AreEqual(string.Format(Constants.expectedFileText,Constants.firstName,Constants.lastName, GetTotalAmount()),ReadingDownloadedFile(Constants.downloadedFilePath));
        }
    }
}
