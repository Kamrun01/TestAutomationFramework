using AutomationFramework.Base;
using AutomationFramework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SalesforceTest.Pages
{
    public class LoginPage : BasePage
    {
        //Login Page elements
        public IWebElement txtUserName => Driver.FindElement(By.Id("username"));
        public IWebElement txtPassword => Driver.FindElement(By.Id("password"));
        public IWebElement btnLogin => Driver.FindElement(By.Id("Login"));
       // public IWebElement lnkHomePage => Driver.FindElement(By.Id("home_Tab"));

        public void Login(string UserName, string Password)
        {
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //Thread.Sleep(3000);
            txtUserName.SendKeys(UserName);
            txtPassword.SendKeys(Password);
        }

        public SalesforcePage ClickLoginButton()
        {
            btnLogin.Click();
            return GetInstance<SalesforcePage>();
        }

        internal void CheckIfLoginExist()
        {
            txtUserName.AssertElementPresent();
        }
    }
}
