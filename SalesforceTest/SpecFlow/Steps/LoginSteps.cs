using AutomationFramework.Base;
using AutomationFramework.Helpers;
using SalesforceTest.Pages;
using TechTalk.SpecFlow;

namespace SalesforceTest.SpecFlow.Steps
{
    [Binding]
    public class LoginSteps : BaseStep
    {
        [Then(@"I should see the username with Raz Mai")]
        public void ThenIShouldSeeTheUsernameWithRazMai()
        {
            if (CurrentPage.As<SalesforcePage>().GetLoggedInUser().Contains("Raz Mai"))
                LogHelper.Write("Logged in Successfully !!!");
            else
                LogHelper.Write("Unsuccessful Login !!!");
        }

    }
}
