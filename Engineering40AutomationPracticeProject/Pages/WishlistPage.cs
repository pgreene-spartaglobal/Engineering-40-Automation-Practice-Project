using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections;
using System.Threading;

namespace Engineering40AutomationPracticeProject.Pages
{
    class WishlistPage
    {

        public IWebDriver driver;
        public WishlistPage() { }
        public WishlistPage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(driver, this);
        }
        /*
        steps i need to do here.
        press wishlist
        type wishlist name
        press save wishlist button
        pressed an item
        add pressed item to wish list
        go back to wishlist page from adding to wishlist
        click on view
        delete new wishlist
        return new wishlist name
        check new wishlist date
        check new wishlist is deleted
        */
        public string GetWishlistItem()
        {
            return WishlistImage.GetAttribute("alt");
        }
        public string GetDate()
        {
            return WishlistDate.Text;
        }
        //wishlist will have a name if its been created. if not it will be null.
        public string GetWishlistName()
        {
            return WishlistName.Text;
        }
        public void ClickOnDeleteButton()
        {
            RemoveWishlistIcon.Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
        public void ClickOnViewButton()
        {
            ViewButton.Click();
        }
        public void GoBackToWishlistPage()
        {
            BackToMyAccount.Click();
            WishlistButton.Click();
        }
        public void AddItemToWishlist()
        {
            AddToWishlistButton.Click();
        }
        public void PressWishlistButton()
        {
            WishlistButton.Click();
        }
        public void TypeWishlistName(string WishlistName)
        {
            NameInputBox.SendKeys(WishlistName);
        }
        public void SaveNewWishlist()
        {
            SaveWishlistButton.Click();
            CloseBox.Click();
        }
        public void PressNewItem()
        {
            ItemTooAdd.Click();
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/div[2]/ul/li/a")]
        public IWebElement WishlistButton;
        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement NameInputBox;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div[2]/div/div[1]/table/tbody/tr/td[4]")]
        public IWebElement WishlistDate;
        [FindsBy(How = How.Id, Using = "submitWishlist")]
        public IWebElement SaveWishlistButton;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div[2]/div/div[1]/table/tbody/tr/td[1]/a")]
        public IWebElement WishlistName;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div[1]/div[1]/div/ul/li[1]/a/img")]
        public IWebElement ItemTooAdd;
        [FindsBy(How = How.Id, Using = "wishlist_button")]
        public IWebElement AddToWishlistButton;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/a")]
        public IWebElement CloseBox;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a")]
        public IWebElement BackToMyAccount;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div[2]/div/div[1]/table/tbody/tr/td[5]/a")]
        public IWebElement ViewButton;
        //we are using the image of the object in the wishlist to verifiy that its the correct one.
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div[2]/div/div[2]/div/div/ul/li/div/div[1]/div/a/img")]
        public IWebElement WishlistImage;

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div[2]/div/div[1]/table/tbody/tr/td[6]/a/i")]
        public IWebElement RemoveWishlistIcon;
        //how to press enter?

    }
}
