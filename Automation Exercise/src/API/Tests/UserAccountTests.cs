using TestAutomationPractice.src.API.Responses.User;
using TestAutomationPractice.src.API.Utilities;
using System.Net;

namespace TestAutomationPractice.src.API.Tests
{
    [TestFixture]
    [Order(7)]
    public class UserAccountTests : ExtentReport
    {
        private string endpoint;
        private Dictionary<string, string> parameters;

        [OneTimeSetUp]
        public void OneTime()
        {
            suiteTest = extent.CreateTest("User Account Test");
            apiClient = new ApiClient();
            endpoint = "/api/getUserDetailByEmail";
        }
        [Test,Order(1)]
        public void Get_UserAccountByEmail()
        {
            test = suiteTest.CreateNode("Test Get User Account By Email.");
            // Arrange
            parameters = new Dictionary<string, string>
            {
                {"email",ConfigurationHelper.Email}
            };
            // Act
            var response = apiClient.Get<UserResponse>(
               endpoint,parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(HttpStatusCode.OK, response.Data.ResponseCode);
            Assert.NotNull(response.Data.User.Id);
            Assert.AreEqual("qatest@gmail.com", response.Data.User.Email);
        }
    }
}
