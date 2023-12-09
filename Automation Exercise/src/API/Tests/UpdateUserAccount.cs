using TestAutomationPractice.src.API.Requests;
using TestAutomationPractice.src.API.Responses;
using TestAutomationPractice.src.API.Utilities;
using System.Net;

namespace TestAutomationPractice.src.API.Tests
{
    [TestFixture]
    [Order(6)]
    public class UpdateUserAccount : ExtentReport
    {
        private string endpoint;
        private CreateAccountRequest account;
        [OneTimeSetUp]
        public void OneTime()
        {
            suiteTest = extent.CreateTest("Update User Account Test");
            apiClient = new ApiClient();
            account = new CreateAccountRequest();
            endpoint = "/api/updateAccount";
        }
        [Test,Order(1)]
        public void Put_UpdateUserAccount()
        {
            test = suiteTest.CreateNode("Test Put Update User Account.");
            //Arrange
            var parameters = new Dictionary<string, string>
            {
                {"name","Mat" },
                {"email",ConfigurationHelper.Email },
                {"password",ConfigurationHelper.Password },
                {"title","Mr" },
                {"birth_date","14" },
                {"birth_month","novembur" },
                {"birth_year","1995" },
                {"firstname","John" },
                {"lastname","Tudor" },
                {"company","Space Y" },
                {"address1","bul.Freedom" },
                {"address2","str.Doom" },
                {"country","United State" },
                {"zipcode","15847" },
                {"state","Utah" },
                {"city","Orem" },
                {"mobile_number","+397114779" },
            };
            // Act
            var response = apiClient.Put<CreateAccountRequest, UpdateUserResponse>(
               endpoint, null, parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(HttpStatusCode.OK, response.Data.ResponseCode);
            Assert.AreEqual("User updated!", response.Data.Message);
        }
    }
}
