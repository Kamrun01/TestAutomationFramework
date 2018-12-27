using AutomationFramework.Base;
using SalesforceTest.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SalesforceTest.SpecFlow.Steps
{
    [Binding]
    public class ExtendedSteps : BaseStep
    {
        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            CurrentPage = GetInstance<LoginPage>();
        }

        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            CurrentPage.As<LoginPage>().CheckIfLoginExist();
        }
        [When(@"I enter UserName and Password")]
        public void WhenIEnterUserNameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage.As<LoginPage>().Login(data.UserName, data.Password);
        }
        [Then(@"I click (.*) link")]
        public void ThenIClickLink(string linkName)
        {
            if (linkName == "home")
                CurrentPage = CurrentPage.As<SalesforcePage>().ClickHomePage();
            else if (linkName == "username")
            {
                CurrentPage.As<HomePage>().ClickbtnAdvertise();
                CurrentPage.As<HomePage>().ClicklnkName();
            }

        }

        [Then(@"I click (.*) button")]
        public void ThenIClickButton(string buttonName)
        {
            if (buttonName == "login")
                CurrentPage = CurrentPage.As<LoginPage>().ClickLoginButton();

        }

    }
}
