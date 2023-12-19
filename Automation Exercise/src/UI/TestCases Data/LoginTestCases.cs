using TestAutomationPractice.Utilities;
using System.Collections;

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
        public static IEnumerable LoginWithValidEmailOrPassowrd()
        {
            yield return new TestCaseData(Constants.email, Constants.password);
            yield return new TestCaseData(Constants.email, Constants.password);
            yield return new TestCaseData(Constants.email, Constants.password);
        }
    }
}
