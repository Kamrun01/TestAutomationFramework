using AutomationFramework.Config;
using OpenQA.Selenium;
using System;
using System.Text;

namespace AutomationFramework.Helpers
{
    public class ScreenshotHelper
    {
        #region screenshots

        public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName)
        {
            var folderLocation =Setting.ScreenShotPath ;//Path of the folder to save the file

            if (!System.IO.Directory.Exists(folderLocation))
            {
                System.IO.Directory.CreateDirectory(folderLocation);
            }

            var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            var fileName = new StringBuilder(folderLocation);

            fileName.Append(ScreenShotFileName);
            fileName.Append(DateTime.Now.ToString("_dd-MM-yyyy_mss"));
            //string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
            fileName.Append(".jpeg");
            screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
            return fileName.ToString();
        }
        #endregion
    }

}

