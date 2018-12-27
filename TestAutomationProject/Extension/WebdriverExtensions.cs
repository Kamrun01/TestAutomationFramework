using AutomationFramework.Base;
using AutomationFramework.Config;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Extension
{
    public static class WebdriverExtensions
    {
        public static void WaitForDocumentLoaded(this IWebDriver driver)
        {
            Func<IWebDriver, bool> runner = new Func<IWebDriver, bool>(waitcondition);
            driver.WaitForCondition<IWebDriver>(runner, Setting.Timeout);

            bool waitcondition(IWebDriver webdriver)
            {
                string state = webdriver.ExecuteJs("return document.readyState").ToString();
                return state == "complete";
            }
        }

        internal static void WaitForCondition<T>(this T obj, Func<T, bool> condition, int timeOut)
        {
            Func<T, bool> execute;
            execute = new Func<T, bool>(CheckCondition);

            var sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < timeOut)
            {
                if (execute(obj))
                {
                    break;
                }
            }


            bool CheckCondition(T arg)
            {
                try
                {
                    return condition(arg);
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        internal static object ExecuteJs(this IWebDriver driver, string script)
        {
            return ((IJavaScriptExecutor)DriverContext.Driver).ExecuteScript(script);
        }
    }
}
