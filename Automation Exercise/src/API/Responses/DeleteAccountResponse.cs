using System.Net;
using System.Text.Json.Serialization;

namespace TestAutomationPractice.src.API.Responses
{
    public class DeleteAccountResponse
    {
        [JsonPropertyName("responseCode")]
        public HttpStatusCode ResponseCode { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
