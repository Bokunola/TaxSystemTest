using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxSystems_Technical_Test.Hooks;

namespace TaxSystems_Technical_Test.PageObjects
{
    public class AddToCartPage
    {
        public IWebDriver driver;

        public AddToCartPage()
        {
            driver = WebHook.driver;
        }

        private By dressName = By.CssSelector("#search_query_top");
        private By searchButton = By.CssSelector("#searchbox > button");
        private By printedDress = By.XPath("//*[@id='center_column']/ul/li[1]/div/div[1]/div/a[1]/img");
        private By blue = By.CssSelector("#color_14");
        private By plusBtn = By.CssSelector(".button-plus.product_quantity_up");
        private By addToCart = By.CssSelector("#add_to_cart > button");
        private By totalValue = By.CssSelector("#layer_cart_product_price");
        private By checkOut = By.CssSelector("a[title='Proceed to checkout']");
        private By description = By.CssSelector("td.cart_description > p > a");
        private By colourSize = By.CssSelector("td.cart_description > small:nth-child(3) > a");
        private By totalProductPrice = By.CssSelector("span[id*='total_product_price']");
        private By totalProducts = By.CssSelector("#total_product");
        private By totalShipping = By.CssSelector("#total_shipping");
        private By totalWithouttax = By.CssSelector("#total_price_without_tax");
        private By totalTax = By.CssSelector("#total_tax");
        private By totalPrice = By.CssSelector("#total_price");
        private By plusIcon = By.CssSelector("a[id*='cart_quantity_up']");




        public void NavigateTowebsite(string url)
        {
            driver.Navigate().GoToUrl(url);

        }

        public void EnterDressName(string dress)
        {
            driver.FindElement(dressName).SendKeys(dress);
        }

        public void ClickSearch()
        {
            driver.FindElement(searchButton).Click();
        }

        public void ClickPrintedDress()
        {
            driver.FindElement(printedDress).Click();
        }

        public void ClickBlue()
        {
            driver.FindElement(blue).Click();
        }

        public void SelectSizeM()
        {
            SelectElement sizeM = new SelectElement(driver.FindElement(By.CssSelector("#group_1")));
            sizeM.SelectByValue("2");
        }

        public void ClickPlusButton()
        {
            driver.FindElement(plusBtn).Click();
        }

        public void ClickAddToCart()
        {
           
            ((IJavaScriptExecutor)driver).ExecuteScript("javascript:window.scrollBy(0,250)");
            driver.FindElement(addToCart).Click();
        }

        public string TotalValueIsDisplayed()
        {
            driver.SwitchTo().ActiveElement();
            
           Task.Delay(3000).Wait();
           string total = driver.FindElement(totalValue).Text;
             return total;
        }

        public void ClickProceedToCheckout()
        {
            driver.FindElement(checkOut).Click();
        }
        
       
        public string Description()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("javascript:window.scrollBy(0,250)");
            string productName = driver.FindElement(description).Text;
            return productName;
            
        }
        public string SizeColour()
        {

            string sizeColour = driver.FindElement(colourSize).Text;
            return sizeColour;
        }
        public string TotalProductPrice()
        {
            Task.Delay(3000).Wait();
            string productPrice = driver.FindElement(totalProductPrice).Text;
            return productPrice;
        }

        public string TotalProducts()
        {

            string productTotal = driver.FindElement(totalProducts).Text;
            return productTotal;
        }
        public string TotalShipping()
        {

            string shippingTotal = driver.FindElement(totalShipping).Text;
            return shippingTotal;
        }

        public string TotalWithoutTax()
        {

            string totalWT = driver.FindElement(totalWithouttax).Text;
            return totalWT;
        }
        public string TotalPrice()
        {
            
            string priceTotal = driver.FindElement(totalPrice).Text;
            return priceTotal;
        }

        public string TotalTax()
        {

            string taxTotal = driver.FindElement(totalTax).Text;
            return taxTotal;
        }

        public void ClickPlusIcon()
        {
            driver.FindElement(plusIcon).Click();
        }

    }
}
