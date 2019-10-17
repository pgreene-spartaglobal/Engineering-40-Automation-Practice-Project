using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using System.Globalization;

namespace Engineering40AutomationPracticeProject.Pages
{
    abstract class ProductPage
    {
        protected IWebDriver driver;

        //cb as Check Box
        [FindsBy(How = How.Id, Using = "layered_id_attribute_group_7")]
        protected IWebElement cbBeige;

        [FindsBy(How = How.Id, Using = "layered_id_attribute_group_8")]
        protected IWebElement cbWhite;

        [FindsBy(How = How.Id, Using = "layered_id_attribute_group_11")]
        protected IWebElement cbBlack;

        [FindsBy(How = How.Id, Using = "layered_id_attribute_group_13")]
        protected IWebElement cbOrage;

        [FindsBy(How = How.Id, Using = "layered_id_attribute_group_14")]
        protected IWebElement cbBlue;

        [FindsBy(How = How.Id, Using = "layered_id_attribute_group_15")]
        protected IWebElement cbGreen;

        [FindsBy(How = How.Id, Using = "layered_id_attribute_group_16")]
        protected IWebElement cbYellow;

        [FindsBy(How = How.Id, Using = "layered_id_attribute_group_24")]
        protected IWebElement cbPink;

        // Composition
        [FindsBy(How = How.Id, Using = "layered_id_feature_5")]
        protected IWebElement cbCotton;

        [FindsBy(How = How.Id, Using = "layered_id_feature_1")]
        protected IWebElement cbPolyester;

        [FindsBy(How = How.Id, Using = "layered_id_feature_3")]
        protected IWebElement cbViscose;

        [FindsBy(How = How.ClassName, Using = "product_list")]
        protected IWebElement ulProductList;

        [FindsBy(How = How.ClassName, Using = "ui-slider-range")]
        protected IWebElement rangeSlider;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void InitPageElements()
        {
            PageFactory.InitElements(driver, this);
        }

        public virtual void GoToPage() { }

        public void ClickBiege()
        {
            cbBeige.Click();
        }

        public void ClickWhite()
        {
            cbWhite.Click();
        }

        public void ClickBlack()
        {
            cbBlack.Click();
        }

        public void ClickOrange()
        {
            cbOrage.Click();
        }

        public void ClickBlue()
        {
            cbBlack.Click();
        }

        public void ClickGreen()
        {
            cbGreen.Click();
        }

        public void ClickYellow()
        {
            cbYellow.Click();
        }

        public void ClickPink()
        {
            cbPink.Click();
        }

        public void ClickCotton()
        {
            cbCotton.Click();
        }

        public void ClickPolyester()
        {
            cbPolyester.Click();
        }

        public void ClickViscose()
        {
            cbViscose.Click();
        }

        public string GetBiegeColour()
        {
            return cbBeige.GetCssValue("background-color");
        }

        public string GetWhiteColour()
        {
            return cbWhite.GetCssValue("background-color");
        }

        public string GetBlackColour()
        {
            return cbBlack.GetCssValue("background-color");
        }

        public string GetOrangeColour()
        {
            return cbOrage.GetCssValue("background-color");
        }

        public string GetBlueColour()
        {
            return cbBlue.GetCssValue("background-color");
        }

        public string GetGreenColour()
        {
            return cbGreen.GetCssValue("background-color");
        }

        public string GetYellowColour()
        {
            return cbYellow.GetCssValue("background-color");
        }

        public string GetPinkColour()
        {
            return cbPink.GetCssValue("background-color");
        }

        public bool ContainColour(string colour, int index)
        {
            //Get all the colour pick list in the page
            IList<IWebElement> colourPickLists;
            colourPickLists = driver.FindElements(By.ClassName("color_to_pick_list"));

            //get the first colour pick list
            IWebElement firstItem = colourPickLists[index];
            IList<IWebElement> colourPick = firstItem.FindElements(By.ClassName("color_pick"));

            //check if the colour is inside the list
            //So, for each colour in the list
            foreach (IWebElement item in colourPick)
            {
                //if the colour of the item is equal to my colour
                if (item.GetCssValue("background-color") == colour)
                {
                    return true;
                }
            }
            return false;
        }

        //public int GetProductListCount()
        //{
        //    IList<IWebElement> productList = ulProductList.FindElements(By.TagName("li"));
        //    return productList.Count;
        //}

        public List<double> GetProductPrices()
        {
            IList<IWebElement> productList = ulProductList.FindElements(By.ClassName("product-price"));
            List<string> priceStringList = new List<string>();
            List<double> priceList = new List<double>();
            foreach (IWebElement item in productList)
            {
                double price;
                double.TryParse(item.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out price);

                priceList.Add(price);
            }

            //foreach (string price in priceStringList)
            //{
            //    decimal p;
            //    Decimal.TryParse(price, out p);
            //    priceList.Add(p);
            //}
            return priceList;
        }

        public bool PriceOutOfRange(double min, double max)
        {
            List<double> priceList = GetProductPrices();
            foreach (double price in priceList)
            {
                if (price < min || price > max)
                {
                    return true;
                }
            }
            return false;
        }

        public List<string> GetProductNames()
        {
            //Get the product name from the list by class name
            IList<IWebElement> products = ulProductList.FindElements(By.ClassName("product-name"));
            //convert the names into string, store in a list
            List<string> itemNames = new List<string>();
            foreach (IWebElement item in products)
            {
                itemNames.Add(item.Text);
            }
            return itemNames;
        }

        public void MoveSlider(int num)
        {
            Actions sliderAction = new Actions(driver);
            sliderAction.ClickAndHold(rangeSlider)
                .MoveByOffset((-(int)rangeSlider.Size.Width / 2), 0)
                .MoveByOffset(num, 0).Release().Perform();
        }

        public void RangeSlider()
        {
            rangeSlider.Click();
        }

        public bool ContainName(string name)
        {
            //Get all the names from the product list
            List<string> productNames = GetProductNames();
            //Get the length of the string parameter
            int length = name.Length;

            foreach (string n in productNames)
            {
                //if the string paramenter is longer than the product name
                if (n.Length - length >= 0)
                {
                    //compare the string paremeter with the end of the product name, also the comparison will ignore case
                    if (n.Substring(n.Length - length).Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
