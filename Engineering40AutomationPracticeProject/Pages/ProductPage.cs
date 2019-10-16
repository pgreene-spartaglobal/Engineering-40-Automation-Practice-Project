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
    class ProductPage
    {
        private readonly IWebDriver driver;

        public ProductPage(IWebDriver driver)
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

        [FindsBy(How = How.Id, Using = "add_to_cart")]
        private readonly IWebElement AddToCart;

        [FindsBy(How = How.ClassName, Using = "icon_ok")]
  
        private readonly IWebElement SuccessfullyAddedShoppingCart;

        public void ChooseQuant(string quantity)
        {
            EnterQuantity.SendKeys(quantity);
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
        //Assert.IsTrue(productPage.CheckSuccess());
        public bool CheckSuccess()
        {
            return SuccessfullyAddedShoppingCart.Displayed;
        }
    }
}
