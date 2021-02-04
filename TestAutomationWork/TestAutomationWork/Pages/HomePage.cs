using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;
using System.Text;
using TestAutomationWork.Base;
using TestAutomationWork.Helpers;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace TestAutomationWork.Pages
{
    public class HomePage : TestBase
    {

        private IWebElement Searchbox_input => "twotabsearchtextbox".FindByID();

        private IWebElement Search_btn => "//input[@id='nav-search-submit-button']".FindByXpath();

        private IList<IWebElement> ProductList => "//span[contains(@class,'a-size-medium a-color-base a-text-normal')]".FindBysXpath();
        public void EnterSearchText(string value)
        {
            Searchbox_input.SendKeys(value);
        }

        public void ClickonSearchButton()
        {
            Search_btn.Click();
        }


        public ProductDetailsPage ClickonFirstResult()
        {
            ProductList.ElementAt(0).Click();
            return new ProductDetailsPage();

        }

    }
}
