using Newtonsoft.Json;

namespace TestAutomationPractice.src.API.Responses.User
{
    public class User
    {
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("birth_date")]
        public string Birth_Date { get; set; }
        [JsonProperty("birth_month")]
        public string Birth_Month { get; set; }
        [JsonProperty("birth_year")]
        public string Birth_Year { get; set; }
        [JsonProperty("firstname")]
        public string FirstName { get; set; }
        [JsonProperty("lastname")]
        public string LastName { get; set; }
        [JsonProperty("company")]
        public string Company { get; set; }
        [JsonProperty("address1")]
        public string Address1 { get; set; }
        [JsonProperty("address2")]
        public string Address2 { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("zipcode")]
        public string ZipCode { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("mobile_numbe")]
        public string Mobile_Number { get; set; }

    }
}
