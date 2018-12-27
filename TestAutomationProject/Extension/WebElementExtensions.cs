using AutomationFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationFramework.Extension
{
    public static class WebElementExtensions
    {
        
       
        public static void AssertElementPresent(this IWebElement element)
        {
            if (!IsElementPresent(element))
                throw new Exception(string.Format("Element not present exception"));
        }
        /// Check if the element exist
        
        private static bool IsElementPresent(IWebElement element)
        {
            try
            {
                bool b = element.Displayed;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void Hover(this IWebElement element)
        {
            Actions action = new Actions(DriverContext.Driver);
            var x = action.MoveToElement(element);
            x.Perform();            
        }

        public static void HoverAndClick(this IWebElement elementToHover, IWebElement elementToCLick)
        {
            Actions action = new Actions(DriverContext.Driver);
            var x = action.MoveToElement(elementToHover);
            var y = x.Click(elementToCLick);
            var z = y.Build();
            z.Perform();

        }
        public static string GetText(this IWebElement element)
        {
            return element.Text;
        }

        public static string GetLinkText(this IWebElement element)
        {
            return element.Text;
        }


        public static void SelectDropDownList(this IWebElement element, string value)
        {
            SelectElement ddl = new SelectElement(element);
            ddl.SelectByText(value);
        }

    }
}
