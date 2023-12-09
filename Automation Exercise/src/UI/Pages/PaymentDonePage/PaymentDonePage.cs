using TestAutomationPractice.Utilities;
using OpenQA.Selenium;
using File = System.IO.File;

namespace TestAutomationPractice.Pages.PaymentDonePage
{
    public partial class PaymentDonePage : BasePage
    {
        public PaymentDonePage(IWebDriver driver) : base(driver)
        {
            
        }
        public override string PageURL => "https://www.automationexercise.com/payment_done/";
        public string GeneratePageUrl(int totalAmount) => $"https://www.automationexercise.com/payment_done/{totalAmount}";
        private string CutUrl => driver.Url.Split("#")[0].ToString();
        private string GetTotalAmount() => CutUrl.Split(new string[] { "e/" }, StringSplitOptions.None)[1].ToString();
        public void DownloadInvoice() => downloadInvoiceButton.Click();
        public void ContinueOrder() => continueButton.Click(); 
        public string ReadingDownloadedFile(string filePath) => File.ReadAllText(filePath);
        public void DeleteDownloadedFile()
        {
             if (File.Exists(Constants.downloadedFilePath))
            {
                File.Delete(Constants.downloadedFilePath);
            }

        }
    }
}
