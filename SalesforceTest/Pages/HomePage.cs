using AutomationFramework.Base;
using OpenQA.Selenium;
using AutomationFramework.Extension;

namespace SalesforceTest.Pages
{
    public class HomePage : BasePage
    {
        //Home page element 
        public IWebElement lnkName => Driver.FindElement(By.LinkText("Raz Mai"));
        public IWebElement btnAdvertise => Driver.FindElement(By.Id("tryLexDialogX"));
        public IWebElement spanFileOpt => Driver.FindElement(By.LinkText("File"));
        public IWebElement linkFileOpt => Driver.FindElement(By.ClassName("publishericon "));
        public void ClicklnkName() => lnkName.Click();
        public void ClickbtnAdvertise() => btnAdvertise.Click();
        public void ClicklnkFileopt() => spanFileOpt.HoverAndClick(linkFileOpt);
    }
}
