using System.Net;

namespace TestAutomationPractice.src.API.Responses
{
    public class ProductResponse
    {
        public HttpStatusCode ResponseCode { get; set; }
        public List<Product> Products { get; set; }
        public string? Message { get; set; }
    }
}
