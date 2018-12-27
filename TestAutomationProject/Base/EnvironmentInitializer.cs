using AutomationFramework.Config;
using AutomationFramework.Helpers;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace AutomationFramework.Base
{
    public class EnvironmentInitializer 
    {
        public readonly BrowserType Browser;

        public EnvironmentInitializer(BrowserType browser)
        {
            Browser = browser;
        }

        //Set all the settings for framework
        public void InitializeSettings()
        {
            
            ConfigReader.SetFrameworkSettings();
            //Set Log
            LogHelper.CreateLogFile();
            OpenBrowser(Browser);
            LogHelper.Write("Initialized Framework");

        }

        //Browser setup
        public void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    var ieCapOptions = new InternetExplorerOptions();
                    ieCapOptions.EnableNativeEvents = false;
                    ieCapOptions.UnhandledPromptBehavior = OpenQA.Selenium.UnhandledPromptBehavior.Accept;
                    ieCapOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    ieCapOptions.EnablePersistentHover = true;
                    ieCapOptions.IgnoreZoomLevel = true;
                    DriverContext.Driver = new InternetExplorerDriver(ieCapOptions);
                    DriverContext.Client = new Browser(DriverContext.Driver);
                    DriverContext.Client.Type = BrowserType.InternetExplorer;

                    break;
                case BrowserType.Firefox:
                    var ieMzCapOptions = new FirefoxOptions();
                    ieMzCapOptions.AddAdditionalCapability("nativeEvents", false);
                    ieMzCapOptions.AddAdditionalCapability("unexpectedAlertBehaviour", "accept");
                    ieMzCapOptions.AddAdditionalCapability("ignoreProtectedModeSettings", true);
                    ieMzCapOptions.AddAdditionalCapability("disable-popup-blocking", true);
                    ieMzCapOptions.AddAdditionalCapability("enablePersistentHover", true);
                    ieMzCapOptions.AddAdditionalCapability("ignoreZoomSetting", true);
                    DriverContext.Driver = new FirefoxDriver(ieMzCapOptions);
                    DriverContext.Client = new Browser(DriverContext.Driver);
                    DriverContext.Client.Type = BrowserType.Firefox;
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Client = new Browser(DriverContext.Driver);
                    DriverContext.Client.Type = BrowserType.Chrome;
                    break;

            }


        }

        public virtual void NavigateSite()
        {
            DriverContext.Client.GotoUrl(Setting.AUT);
        }
    }
}
