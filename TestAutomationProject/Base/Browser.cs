using OpenQA.Selenium;


namespace AutomationFramework.Base
{
    public class Browser
    {
        private readonly IWebDriver driver;

        public Browser(IWebDriver Driver)
        {
            driver = Driver;
        }
        public BrowserType Type { get; set; }

        public void GotoUrl(string url)
        {
            driver.Url = url;
        }
    }

    public enum BrowserType
    {
        InternetExplorer,
        Firefox,
        Chrome
    }
}
