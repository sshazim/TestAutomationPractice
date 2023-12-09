namespace TestAutomationPractice.src.API.Utilities
{
    public class ConfigurationHelper
    {
        public static string BaseUrl { get; private set; } = "https://automationexercise.com";
        public static string Password { get; private set; } = "testqa1";
        public static string Email { get; private set; } = "qatest@gmail.com";


        public static void SetBaseUrl(string baseUrl)
        {
            BaseUrl = baseUrl;
        }
        public static void SetPassword(string password)
        {
            Password = password;
        }
        public static void SetEmail(string email)
        {
            Email = email;
        }
    }
}
