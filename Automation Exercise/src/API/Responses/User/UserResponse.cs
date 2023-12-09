using System.Net;

namespace TestAutomationPractice.src.API.Responses.User
{
    public class UserResponse
    {
        public HttpStatusCode ResponseCode { get; set; }
        public User User { get; set; }
    }
}
