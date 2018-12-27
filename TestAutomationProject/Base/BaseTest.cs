using NUnit.Framework;

namespace AutomationFramework.Base
{
    public class BaseTest :Base
    {
        [SetUp]
        //setup initializer
        public void SetUp()
        {
            var initializer = new EnvironmentInitializer(BrowserType.Chrome);
            initializer.InitializeSettings();
            initializer.NavigateSite();
        }
    }
}
