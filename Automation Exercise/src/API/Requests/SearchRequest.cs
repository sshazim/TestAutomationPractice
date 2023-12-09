using Newtonsoft.Json;

namespace TestAutomationPractice.src.API.Requests
{
    public class SearchRequest
    {
        [JsonProperty("search_product")]
        public string SearchProduct { get; set; }
    }

}
