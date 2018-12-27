using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomationFramework.Base
{
    public class Base
    {
        //Get the current page instance
        public virtual BasePage CurrentPage
        {
            get; set;
        }
        protected Base()
        {
            this.driver = DriverContext.Driver;
        }

        protected IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }
        IWebDriver driver;

        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage();
            return pageInstance;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
