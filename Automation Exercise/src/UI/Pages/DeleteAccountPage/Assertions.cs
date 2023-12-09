using TestAutomationPractice.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationPractice.Pages.DeleteAccountPage
{
    partial class DeleteAccountPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - Account Created", GetPageTitle());
        }
        public void AssertCorrectAccountDeleteMessageIsDisplayed()
        {
            Assert.AreEqual("ACCOUNT DELETED!", accountDeleteMsg.Text);
        }
        public void AssertCorrectSuccessfullMessageIsDisplayed()
        {
            Assert.AreEqual(SuccessfulMessages.accountDeleted, firstAccountDeletedSuccessfullMsg.Text);
        }
        public void AssertCorrectSecondSuccessfullMessageIsDisplayed()
        {
            Assert.AreEqual(SuccessfulMessages.secondAccountDeleted, secondAccountDeletedSuccessfullMsg.Text);
        }
        public void AsserCountinueButtonIsDisplayed()
        {
            Assert.True(continueButton.Displayed);
        }
    }
}
