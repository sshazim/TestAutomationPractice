using TestAutomationPractice.Utilities;
using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.ProductDetailsPage
{
    partial class ProductDetailsPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - Product Details", GetPageTitle());
        }
        public void AssertProductPictureIsDisplayed()
        {
            Assert.True(productPicture.Displayed);
        }
        public void AssertCorrectProductDetailsPageIsOpened(int productId)
        {
            Assert.AreEqual(GeneratePageDetailsUrl(productId), GetPageUrl());
        }
        public void AssertCorrectProductName(string nameOfProduct)
        {
            Assert.AreEqual(nameOfProduct, productName.Text);
        }
        public void AssertProductIsAvailable()
        {
            Assert.AreEqual("Availability: In Stock", avaliableInfo.Text);
        }
        public void AssertCorrectProductCondition(string condition)
        {
            Assert.AreEqual($"Condition: {condition}", conditionInfo.Text);
        }
        public void AssertCorrectProductBrandName(Brands brandName)
        {
            Assert.AreEqual($"Brand: {brandName}", brandInfo.Text);
        }
        public void AssertCorrectProductPrice(int expected)
        {
            Assert.AreEqual(expected, GetProductPrice());
        }
        public void AssertErrorEmptyFieldMessageIsDisplayed(IWebElement field)
        {
            Assert.AreEqual(ErrorMessages.emptyField, ValidationMessage(field));
        }
        public void AssertErrorInvalidEmailAddressMessageIsDisplayed(IWebElement field, string email)
        {
            Assert.AreEqual(string.Format(ErrorMessages.incorrectEmailAddress, email), ValidationMessage(field));
        }
        public void AssertErrorIncompleteEmailAddressMessageIsDisplayed(IWebElement field, string email)
        {
            Assert.AreEqual(string.Format(ErrorMessages.incompleteEmailAddress, email), ValidationMessage(field));
        }
        public void AssertAddedIconIsDisplayed()
        {
            Assert.True(successfulAddedIcon.Displayed);
        }
        public void AssertProductAddedSuccessfulTextIsDisplayed()
        {
            Assert.AreEqual(SuccessfulMessages.productAddSuccessful, productAddedSuccessfulMsg.Text);
        }
        public void AssertSuccessfulSubmiteReviewMessageIsDisplayed()
        {
            Assert.True(successfulReviewSubmit.Displayed);
            Assert.AreEqual(SuccessfulMessages.successfulSubmiteReviewMsg, successfulReviewSubmit.Text);
        }
    }
}

