using TestAutomationPractice.Utilities;
using System.Collections;
using TestAutomationPractice.Pages.LoginPage;
using TestAutomationPractice.Pages.SignupPage;

namespace TestAutomationPractice.src.UI.TestData
{
    public static class LoginTestCases
    {
        public static IEnumerable LoginWithoutEmailOrPassowrdCases()
        {
            yield return new TestCaseData(Constants.email, "");
            yield return new TestCaseData("", Constants.password);
            yield return new TestCaseData("", "");
        } 
        public static IEnumerable LoginWithInvalidEmailOrPassowrd()
        {
            yield return new TestCaseData(Constants.email, "qatest");
            yield return new TestCaseData("incorrectEmail", Constants.password);
            yield return new TestCaseData("incorrectEmail@", Constants.password);
        }

        public static IEnumerable LoginWithValidEmailAndPassword()
        {
            yield return new TestCaseData(Constants.email, Constants.password);
            yield return new TestCaseData("khadar@bgv.bg", Constants.password);
        }
    }
}
