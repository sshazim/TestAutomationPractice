﻿using TestAutomationPractice.Pages.PaymentPage;
using TestAutomationPractice.src.UI.TestData;
using TestAutomationPractice.Utilities;

namespace TestAutomationPractice.Test_Scripts
{
    [TestFixture]
    [Order(10)]
    internal class PaymentDonePageTest : BaseTest
    {
        private CardInfo cardInfo;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            suiteTest = extent.CreateTest("PaymentDone Page Tests");
            UserLogin();
        }

        [Test, Order(1), Category("Test Case 16"), Category("Excercise Test")]
        public void VerifyCompleteOrderWihtoutAddedProduct()
        {
            test = suiteTest.CreateNode("Test Complete order workflow with added product.");
            paymentPage.Open();
            paymentPage.AssertCorrectPageIsLoaded();
            paymentPage.AssertCorrectPaymentTitleIsDisplayed();
            paymentPage.AssertCorrectPaymentFormIsDisplayed();
            cardInfo = new CardInfo()
            {
                NameOnCard = $"{Constants.firstName} {Constants.lastName}",
                CardNumber = Constants.cardNumber,
                CVC = Constants.CVC,
                ExpirationMonth = Constants.expirationMonth,
                ExpirationYear = Constants.expirationYear,
            };
            paymentPage.FillPaymentForm(cardInfo);
            paymentPage.ClickOnPayOrder();
            AdverticeHelper.CheckForAdvertice(driver);
            paymentDonePage.AssertCorrectOrderTitleIsDisplayed();
            paymentDonePage.AssertOrderConfirmedMessageIsDisplayedCorrectly();
            paymentDonePage.ContinueOrder();
            homePage.AssertCorrectPageIsLoaded();
        }
    }
}
