using AutomationFramework.Base;
using AutomationFramework.Extension;
using OpenQA.Selenium;


namespace SalesforceTest.Pages
{
    public class SalesforcePage:BasePage
    {
        //Salesforce page elements
        public IWebElement lnkHomePage => Driver.FindElement(By.Id("home_Tab"));
        public IWebElement lnkLoggedInUser => Driver.FindElement(By.Id("userNavLabel"));
        public HomePage ClickHomePage()
        {
            lnkHomePage.Click();
            return GetInstance<HomePage>();
        }
        internal string GetLoggedInUser()
        {
            return lnkLoggedInUser.GetLinkText();
        }
    }
}
