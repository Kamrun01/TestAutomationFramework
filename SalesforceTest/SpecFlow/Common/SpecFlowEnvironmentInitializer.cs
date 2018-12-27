using AutomationFramework.Base;
using AutomationFramework.Helpers;
using TechTalk.SpecFlow;

namespace SalesforceTest.SpecFlow
{
    [Binding]
    public class SpecFlowEnvironmentInitializer
    {
        [BeforeTestRun]
        public static void SpecFlowSetUp()
        {
            var initializer = new EnvironmentInitializer(BrowserType.Chrome);
            initializer.InitializeSettings();
            initializer.NavigateSite();
            ReportingHelper.InitalizeExtentReport();
        }


        [AfterTestRun]
        public static void SpecFlowTearDown()
        {
            ReportingHelper.TearDownReport();
        }

        [BeforeFeature]
        public static void SpecflowFeatureSetUp()
        {
            ReportingHelper.BeforeFeature();
        }

        [BeforeScenario]
        public static void SpecflowScenarioSetUp()
        {
            ReportingHelper.BeforeScenario();
        }

        [AfterStep]
        public static void SpecflowAfterEachStep()
        {
            ReportingHelper.AfterEachStep();
        }
    }
}
