using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework.Interfaces;

namespace TestAutomationPractice.src.API.Utilities
{
    public class ExtentReport
    {
        protected ApiClient apiClient;
        protected static ExtentReports extent;
        protected ExtentTest suiteTest;
        protected ExtentTest test;
        [OneTimeSetUp]
        public void BaseSetUp()
        {
            if (extent == null)
            {
                var htmlReporter = new ExtentHtmlReporter(@"..\..\..\src\Common\Test Results\API\results.html");
                htmlReporter.Config.DocumentTitle = "Test Automation Report";
                htmlReporter.Config.Encoding = "UTF-8";
                htmlReporter.Config.Theme = Theme.Dark;
                extent = new ExtentReports();
                extent.AddSystemInfo("OS", Environment.OSVersion.ToString());
                extent.AddSystemInfo("Framework", "NUnit ver.3.13.3<br>RestSharp ver.110.2.0");
                extent.AddSystemInfo(".NET Version", Environment.Version.ToString());
                extent.AttachReporter(htmlReporter);
            }
        }
        [TearDown]
        public void AfterTest()
        {
            // Get the test result and update the test status
            var message = TestContext.CurrentContext.Result.Message;
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            if (status == TestStatus.Failed)
            {
                test.Fail($"Test has failed.<br>{message}");
            }
            else if (status == TestStatus.Passed)
            {
                test.Pass($"Test has passed.<br>{message}");
            }
            else if (status == TestStatus.Skipped)
            {
                test.Skip($"Test skipped.<br>{message}");
            }
            extent.Flush();
        }
        [OneTimeTearDown]
        protected void EndReport()
        {
            extent.Flush(); //End report
        }
    }
}
