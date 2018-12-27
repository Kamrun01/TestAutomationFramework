using System;
using System.IO;
using System.Reflection;
using System.Xml.XPath;


namespace AutomationFramework.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {

            XPathItem aut;
            XPathItem testtype;
            XPathItem timeout;
            XPathItem islog;
            XPathItem isreport;
            XPathItem buildname;
            XPathItem logPath;
            XPathItem reportPath;
            XPathItem reportConfigPath;
            XPathItem screenshotPath;

            string currentAssemblyPath = Assembly.GetExecutingAssembly().Location;
            string strFilename = Path.GetDirectoryName(currentAssemblyPath) + "\\Config\\GlobalConfig.xml";
            FileStream stream = new FileStream(strFilename, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            //Get XML Details and pass it in XPathItem type variables
            aut = navigator.SelectSingleNode("AutomationFramework/RunSettings/AUT");
            buildname = navigator.SelectSingleNode("AutomationFramework/RunSettings/BuildName");
            testtype = navigator.SelectSingleNode("AutomationFramework/RunSettings/TestType");
            islog = navigator.SelectSingleNode("AutomationFramework/RunSettings/IsLog");
            timeout= navigator.SelectSingleNode("AutomationFramework/RunSettings/TimeOut");
            isreport = navigator.SelectSingleNode("AutomationFramework/RunSettings/IsReport");
            logPath = navigator.SelectSingleNode("AutomationFramework/RunSettings/LogPath");
            reportPath= navigator.SelectSingleNode("AutomationFramework/RunSettings/ReportPath");
            reportConfigPath= navigator.SelectSingleNode("AutomationFramework/RunSettings/ReportConfigPath");
            screenshotPath = navigator.SelectSingleNode("AutomationFramework/RunSettings/ScreenShotPath");
            

            //Set XML Details in the property to be used accross framework
            Setting.AUT = aut.Value.ToString();
            Setting.BuildName = buildname.Value.ToString();
            Setting.TestType = testtype.Value.ToString();
            Setting.IsLog = islog.Value.ToString();
            Setting.IsReporting = isreport.Value.ToString();
            Setting.Timeout = Convert.ToInt32(timeout.Value);
            Setting.LogPath = logPath.Value.ToString();
            Setting.ReportPath = reportPath.Value.ToString();
            Setting.ReportConfigPath = reportConfigPath.Value.ToString();
            Setting.ScreenShotPath = screenshotPath.Value.ToString();
        }

    }
}
