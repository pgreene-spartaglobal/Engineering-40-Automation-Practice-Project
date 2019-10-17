using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Engineering40AutomationPracticeProject.Pages
{
    class PurchasingProductPage
    {
        private readonly IWebDriver driver;

        public PurchasingProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "quantity_wanted")]
        private readonly IWebElement EnterQuantity;

        [FindsBy(How = How.Id, Using = "group_1")]
        private readonly IWebElement SelectSize;
        SelectElement selectSizeElement;

        [FindsBy(How = How.Id, Using = "color_13")]
        private readonly IWebElement ChooseColor;

        [FindsBy(How = How.XPath, Using = "//*[@id='add_to_cart']/button")]
        private readonly IWebElement AddToCart;

        [FindsBy(How = How.ClassName, Using = "icon_ok")]
        private readonly IWebElement SuccessfullyAddedShoppingCart;



        public void ChooseQuant(string quantity)
        {
            EnterQuantity.SendKeys(quantity);
        }

        public void clearQuant()
        {
            EnterQuantity.Clear();
        }

        public void ChooseColour()
        {
            ChooseColor.Click();
        }
        public void ChooseSize(string size)
        {
            selectSizeElement = new SelectElement(SelectSize);
            selectSizeElement.SelectByText(size);
        }

        public void AddToCart1()
        {
            AddToCart.Click();
        }
       
        public string SuccessfulAddToTheCart()
        {
            return "Product successfully added to your shopping cart";
        }
       
    }
}
