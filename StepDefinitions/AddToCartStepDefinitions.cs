using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TaxSystems_Technical_Test.Hooks;
using TaxSystems_Technical_Test.PageObjects;
using TechTalk.SpecFlow;

namespace TaxSystems_Technical_Test.StepDefinitions
{
    [Binding]
    public class AddToCartStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;

        AddToCartPage _addToCartPage = new AddToCartPage();

        [Given(@"a user navigate to the Website")]
        public void GivenAUserNavigateToTheWebsite()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            
        }

        [When(@"a user enter ""([^""]*)"" in search box")]
        public void WhenAUserEnterInSearchBox(string dress)
        {
            _addToCartPage.EnterDressName(dress);
        }
        [When(@"a user click search")]
        public void WhenAUserClickSearch()
        {
            _addToCartPage.ClickSearch();
        }


        [When(@"a user select dress with price value \$(.*)")]
        public void WhenAUserSelectDressWithPriceValue(Decimal p0)
        {
           _addToCartPage.ClickPrintedDress();
        }

        [When(@"a user change colour to Blue")]
        public void WhenAUserChangeColourToBlue()
        {
            _addToCartPage.ClickBlue();
        }


        [When(@"a user click on dropdown to change size to M")]
        public void WhenAUserCleckOnDropdownToChangeSizeToM()
        {
            _addToCartPage.SelectSizeM();
        }

        [When(@"a user click on plus icon to change quantity to (.*)")]
        public void WhenAUserClickOnPlusIconToChangeQuantityTo(int p0)
        {
            _addToCartPage.ClickPlusButton();
        }

        [When(@"a user click on Add to Cart")]
        public void WhenAUserClickOnAddToCart()
        {
            _addToCartPage.ClickAddToCart();
        }


        [Then(@"the total value ""([^""]*)"" is displayed")]
        public void ThenTheTotalValueIsDisplayed(string value)
        {
           
            Assert.AreEqual(value, _addToCartPage.TotalValueIsDisplayed());
        }

        [When(@"a user click on on proceed to checkout")]
        public void WhenAUserClickOnOnProceedToCheckout()
        {
            _addToCartPage.ClickProceedToCheckout();
        }

        [When(@"a user click on plus icon to increase quantity to (.*)")]
        public void ThenAUserClickOnPlusIconToIncreaseQuantityTo(int p0)
        {
            _addToCartPage.ClickPlusIcon();
        }

        [Then(@"the basket should contain ""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"" is updated")]
        public void ThenTheBasketShouldContainIsUpdated(string description, string sizeColour, string tproduct, string tproducts, string tshipping, string withholdtax, string tax, string tprice)
        {
            Assert.AreEqual(description, _addToCartPage.Description());
            Assert.AreEqual(sizeColour, _addToCartPage.SizeColour());
            Assert.AreEqual(tproduct, _addToCartPage.TotalProductPrice());
            Assert.AreEqual(tproducts, _addToCartPage.TotalProducts());
            Assert.AreEqual(tshipping, _addToCartPage.TotalShipping());
            Assert.AreEqual(withholdtax, _addToCartPage.TotalWithoutTax());
            Assert.AreEqual(tax, _addToCartPage.TotalTax());
            Assert.AreEqual(tprice, _addToCartPage.TotalPrice());
        }



    }
}
