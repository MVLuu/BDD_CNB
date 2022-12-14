using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_CNB.PageObjects
{
    public class Preferred
    {
        IWebDriver _webDriver;
        public Preferred(IWebDriver webDriver)
        {
            validatPageLoads();
            _webDriver = webDriver;
        }

        public void validatPageLoads()
        {
            // Confirm title
            // Else throw page load failure exception.
        }

        public string GetPageName()
        {
            return _webDriver.Title;
        } 
    }
}
