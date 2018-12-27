using OpenQA.Selenium;

namespace AutomationFramework.Base
{
    public static class DriverContext
    {
       
        public static IWebDriver Driver
        {
            get;
            set;
        }
        public static Browser Client { get; set; }
    }
}
