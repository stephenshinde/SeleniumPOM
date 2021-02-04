using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestAutomationWork.Base;


namespace TestAutomationWork.Helpers
{
    public static class DriverExtension
    {
        public static IWebElement FindByID(this string selector)
        {
            try
            {
                var element = DriverFactory.webDriver.FindElement((By.Id(selector)));
                return element;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
                
            }
        }


        public static IWebElement FindByXpath(this string selector)
        {
            try
            {
                var element = DriverFactory.webDriver.FindElement((By.XPath(selector)));
                return element;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;

            }
        }

        public static IWebElement FindBySelector(this string selector)
        {
            try
            {
                var element = DriverFactory.webDriver.FindElement((By.CssSelector(selector)));
                return element;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;

            }
        }

        public static IList<IWebElement> FindBysSelector(this string selector)
        {
            try
            {
                var element = DriverFactory.webDriver.FindElements((By.CssSelector(selector)));
                return element;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;

            }
        }


        public static IList<IWebElement> FindBysXpath(this string selector)
        {
            try
            {
                var element = DriverFactory.webDriver.FindElements((By.XPath(selector)));
                return element;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;

            }
        }
    }
}
