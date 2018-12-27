using AutomationFramework.Base;
using OpenQA.Selenium;


namespace SalesforceTest.Pages
{
    public class SetUpPage: BasePage
    {
       
        public IWebElement lnkSetup => Driver.FindElement(By.LinkText("Setup"));
    }
}
