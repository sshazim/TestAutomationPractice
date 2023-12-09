using TestAutomationPractice.Utilities;

namespace TestAutomationPractice.Pages.SignupPage
{
    public class AccountInfo
    {
      
        public string Title { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Password { get; set; }
        public DayOfMonth DayOfMonth { get; set; }
        public MonthOfYear MonthOfYear { get; set; }
        public Years Years { get; set; }
        public string? FirstName { get; set; }
        public string LastName { get; set; }
        public string? Company { get; set; }
        public string? Address1 { get; set; }
        public string Address2 { get; set; }
        public string Country { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? MobileNumber { get; set; }

    }
}
