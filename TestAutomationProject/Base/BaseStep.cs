using TechTalk.SpecFlow;

namespace AutomationFramework.Base
{

    public class BaseStep : Base
    {
        public override BasePage CurrentPage
        {
            get => (BasePage)ScenarioContext.Current["currentPage"];
            set => ScenarioContext.Current["currentPage"] = value;
        }
    }
}
