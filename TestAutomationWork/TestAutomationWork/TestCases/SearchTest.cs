using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestAutomationWork.Base;
using TestAutomationWork.Pages;

namespace TestAutomationWork.TestCases
{
     public class SearchTest : TestBase
    {
        [Test]
        public void SearchLaptop()
        {
            HomePage homepage = new HomePage();
            homepage.EnterSearchText("Laptop");
            homepage.ClickonSearchButton();
            var productdetails = homepage.ClickonFirstResult();
            Assert.Greater(productdetails.Get_Price_Value(), 100);
        }
    }
}
