using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationWork.Base
{
   public class TestBase
    {
        public static string currentDir = Environment.CurrentDirectory;
        public static string[] Solutionpath = currentDir.Split("bin");

        [SetUp]
        public void InitializeTest()
        {
            //DriverFactory.webDriver = new ChromeDriver(@"E:\StephenTestAutomation\TestAutomationWork\TestAutomationWork\Drivers\");
            DriverFactory.webDriver = new ChromeDriver(Solutionpath[0] + @"Drivers\");
            DriverFactory.webDriver.Url = "https://www.amazon.com/";
            DriverFactory.webDriver.Manage().Window.Maximize();
            DriverFactory.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        [TearDown]
        public void TearDown()
        {
            DriverFactory.webDriver.Quit();
        }
    }
}
