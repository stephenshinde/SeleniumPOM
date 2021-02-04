using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationWork.Base
{
   public class DriverFactory
    {
        private static IWebDriver _driver;

        public static IWebDriver webDriver
        {
            get
            {
                return _driver;
            }

            set
            {
                _driver = value;
            }
        }


    }
}
