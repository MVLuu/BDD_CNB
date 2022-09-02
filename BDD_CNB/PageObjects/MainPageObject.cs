using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace BDD_CNB.PageObjects
{
    public class MainPageObject
    {
        //The URL of the main CNB page to be opened in the browser
        private const string CNBUrl = "https://cnb.com";

        //The Selenium web driver to automate the browser
        private readonly IWebDriver _webDriver;

        //The default wait time in seconds for wait.Until
        public const int DefaultwaitInSeconds = 5;

        public MainPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        //Finding elements by ID
        private ReadOnlyCollection<IWebElement> BankPreferredButtons => _webDriver.FindElements(By.LinkText("LEARN MORE"));
        
        public Preferred ClickPreferredButton()
        {
            BankPreferredButtons[0].Click();
            return new Preferred(_webDriver);
        }

        public void CleanTestData()
        {

        }

        public void EnsureCNBPageIsOpen()
        {
            if(_webDriver.Url != CNBUrl)
            {
                _webDriver.Url = CNBUrl;
            }    
        }

        /// <summary>
        /// Helper method to wait until the expected result is available on the UI
        /// </summary>
        /// <typeparam name="T">The type of result to retrieve</typeparam>
        /// <param name="getResult">The function to poll the result from the UI</param>
        /// <param name="isResultAccepted">The function to decide if the polled result is accepted</param>
        /// <returns>An accepted result returned from the UI. If the UI does not return an accepted result within the timeout an exception is thrown.</returns>
        private T WaitUntil<T>(Func<T> getResult, Func<T, bool> isResultAccepted) where T: class
        {
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(DefaultwaitInSeconds));
            return wait.Until(driver =>
            {
                var result = getResult();
                if (!isResultAccepted(result))
                    return default;

                return result;
            });
        }
    }
}
