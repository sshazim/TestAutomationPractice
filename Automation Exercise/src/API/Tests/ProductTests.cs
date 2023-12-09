using TestAutomationPractice.src.API.Responses;
using TestAutomationPractice.src.API.Utilities;
using System.Net;

namespace TestAutomationPractice.src.API.Tests
{
    [TestFixture]
    [Order(3)]
    public class ProductTests : ExtentReport
    {
        private string endpoint;
        private Dictionary<string, string> parameters;
        [OneTimeSetUp]
        public void OneTIme()
        {
            suiteTest = extent.CreateTest("Product Test");
            apiClient = new ApiClient();
            endpoint = "/api/productsList";
        }
        [Test,Order(1)]
        public void Get_AllProduct()
        {
            test = suiteTest.CreateNode("Test Get All Products.");
            // Act
            var response = apiClient.Get<ProductResponse>(endpoint);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(400,response.StatusCode);
            Assert.NotNull(response.Data);
            Assert.That(response.Data.Products.Count,Is.GreaterThan(0));
        }
        [Test,Order(2)]
        public void Post_AllProduct()
        {
            test = suiteTest.CreateNode("Test Post All Products.");
            // Act
            var response = apiClient.Post<object, ProductResponse>(endpoint, null, parameters);
            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(HttpStatusCode.MethodNotAllowed, response.Data.ResponseCode);
            Assert.AreEqual("This request method is not supported.", response.Data.Message);
        }
    }
}
