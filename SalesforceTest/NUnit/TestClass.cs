using AutomationFramework.Base;
using AutomationFramework.Helpers;
using AutomationFramework.Extension;
using NUnit.Framework;
using SalesforceTest.Pages;
using System;
using System.IO;
using System.Reflection;

namespace SalesforceTest
{
    [TestFixture]
    public class TestClass : BaseTest
    {
      
        [Test]
        public void Test1()
        {
            //Reading data from excel
            string currentAssemblyPath = Assembly.GetExecutingAssembly().Location;
            string datafileName = Path.GetDirectoryName(currentAssemblyPath) + "\\Data\\SalesforceCredentials.xlsx";
            ExcelHelper.PopulateInCollection(datafileName);

            CurrentPage = GetInstance<LoginPage>();
           // CurrentPage.As<LoginPage>().CheckIfLoginExist();
            CurrentPage.As<LoginPage>().Login(ExcelHelper.ReadData(1, "UserName"), ExcelHelper.ReadData(1, "Password"));
            LogHelper.Write("Logged in Successfully !!!");
            DriverContext.Driver.WaitForDocumentLoaded();
           // DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //take screenshot
            String img = ScreenshotHelper.SaveScreenshot(DriverContext.Driver, "Report");
            CurrentPage = CurrentPage.As<LoginPage>().ClickLoginButton();
            CurrentPage= CurrentPage.As<SalesforcePage>().ClickHomePage();
            CurrentPage.As<HomePage>().ClickbtnAdvertise();
            CurrentPage.As<HomePage>().ClicklnkName(); 
            //CurrentPage.As<HomePage>().ClicklnkFileopt();
        }


    }
}
