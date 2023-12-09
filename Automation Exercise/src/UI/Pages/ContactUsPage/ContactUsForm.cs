using TestAutomationPractice.Utilities;

namespace TestAutomationPractice.Pages.ContactUsPage
{
    public class ContactUsForm
    {
        public string Name { get; set; }
        public string? Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string? ChoosenFile { get; set; }
    }
}
