using OpenQA.Selenium;
using TestAutomationWork.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationWork.Pages
{
    public class ProductDetailsPage
    {
        private string productprice;
        private IWebElement Price_Value => "priceblock_ourprice".FindByID();

        private IWebElement Price_Value_Sale => "priceblock_saleprice".FindByID();
        


        public decimal Get_Price_Value()
        {
            if (Price_Value.Displayed)
            {
                productprice = Price_Value.Text;
            }
            else
            {
                productprice = Price_Value_Sale.Text;
            }
          
           char[] charsToTrim = { '$' };
           string price = productprice.Trim(charsToTrim);
           return Convert.ToDecimal(price);
        }
        
    }
}
