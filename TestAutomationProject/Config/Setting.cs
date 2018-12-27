using AutomationFramework.Base;

namespace AutomationFramework.Config
{
    //Properties for config file
    public class Setting
    {
        public static int Timeout { get; set; }

        public static string IsReporting { get; set; }

        public static string TestType { get; set; }

        public static string AUT { get; set; }

        public static string BuildName { get; set; }

        public static BrowserType BrowserType { get; set; }

        public static string IsLog { get; set; }

        public static string LogPath { get; set; }

        public static string ReportPath { get; set; }

        public static string ReportConfigPath { get; set; }

        public static string ScreenShotPath { get; set; }
    }
}
