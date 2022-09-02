using BDD_CNB.Drivers;
using BDD_CNB.PageObjects;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_CNB.Hooks
{
    [Binding]
    public class MainHooks
    {
        ///<summary>
        /// Tasks to complete before each scenario tagged with "Main"
        ///</summary>
        [BeforeScenario("CNBPreferred")]
        public static void BeforeScenario(BrowserDriver browserDriver)
        {
            var mainPageObject = new MainPageObject(browserDriver.Current);
            mainPageObject.EnsureCNBPageIsOpen();
        }
    }
}
