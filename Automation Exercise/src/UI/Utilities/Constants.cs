using System.Security.Cryptography;
using TestAutomationPractice.Pages.LoginPage;
using TestAutomationPractice.Test_Scripts;

namespace TestAutomationPractice.Utilities
{
    public static class Constants
    {
        public const string downloadedFilePath = @"C:\Users\User\Downloads\invoice.txt"; // For different browsers this path will be different.
        public const string choosenFilePath = @"C:\Downloads\validation.jpg";
        public const string expectedFileText = "Hi {0} {1}, Your total purchase amount is {2}. Thank you"; // {0} is firstName, {1} is lastName and {2} is order amount.     
        public const string title = "Mr";
        public const string name = "Mat";
        public const string username = "testqa1";
        public const string password = "testqa1";
        public const string firstName = "Matthew";
        public const string lastName = "Tudor";
        public const string email = "justfortest777@abv.bg";
        public const string firstAddress = "Yalta str";
        public const string secondAddress = "Bulgaria bul";
        public const string companyName = "Space Z";
        public const string state = "Sula";
        public const string city = "Hamilton";
        public const string country = "Australia";
        public const string zipCode = "64834";
        public const string mobileNumber = "(492) 957-325";
        public const string homePageDescription = "All QA engineers can use this website for automation practice and API testing either they are at beginner or advance level. This is for everybody to help them brush up their automation skills.";
        public const string homePageHeadingDescription = "Full-Fledged practice website for Automation Engineers";
        public const string cardNumber = "7271 9888 3445 9541";
        public const string CVC = "672";
        public const string expirationMonth = "09";
        public const string expirationYear = "29";
        public const string contactUsMessage = "Dear [Site Support Team/Technical Support Team],\r\n I hope this email finds you well. I am writing to request the addition of validation on an important field within the https://automationexercise.com. This enhancement will help ensure data accuracy, integrity, and provide a better user experience for all users.";
        public const string contactUsSubject = "Field validations.";
        public const string carouselFirstText = "AutomationExercise";
        public const string carouselSecondText = "Full-Fledged practice website for Automation Engineers";
        public const string carouselThirdText = "All QA engineers can use this website for automation practice and API testing either they are at beginner or advance level. This is for everybody to help them brush up their automation skills.";
        public const string productReviewText = "I highly recommend this product to anyone in need. It's a valuable addition to any setup. Thank you for creating such a fantastic product!";
        public const string feedbackInfoText = "We really appreciate your response to our website.\r\n\r\nKindly share your feedback with us at feedback@automationexercise.com.\r\n\r\nIf you have any suggestion areas or improvements, do let us know. We will definitely work on it.\r\n\r\nThank you";
        public const string emptyCartText = "Cart is empty! Click here to buy products.";


    }
}
