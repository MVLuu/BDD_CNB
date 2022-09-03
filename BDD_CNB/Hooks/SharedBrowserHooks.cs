using BDD_CNB.Drivers;
using BoDi;
using TechTalk.SpecFlow;

namespace BDD_CNB.Hooks
{
    [Binding]
    public class SharedBrowserHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun(ObjectContainer testThreadContainer)
        {
            //Initialize a shared BrowserDriver in the global container
            testThreadContainer.BaseContainer.Resolve<BrowserDriver>();
        }
    }
}
