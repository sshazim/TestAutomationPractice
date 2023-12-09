using RestSharp;

namespace TestAutomationPractice.src.API.Model
{
    public class ApiRequest<TRequest>
    {
        public string Endpoint { get; set; }
        public Method Method { get; set; }
        public TRequest Data { get; set; }
        public Dictionary<string,string> Parameter { get; set; }
    }
}
