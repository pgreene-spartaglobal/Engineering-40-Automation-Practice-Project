using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class WishlistEditSteps
    {
        IWebDriver driver;
        LoginPage ba;
        WishlistPage wishlistPage;
        [Given(@"I have logged in correctly")]
        public void GivenIHaveLoggedInCorrectly()
        {
            driver = new ChromeDriver();
            ba = new LoginPage(driver);
            wishlistPage = new WishlistPage(driver);
            ba.CiaranLogIn("a@b.a", "ababa");
        }
        
        [Given(@"i have pressed the wishlist button")]
        public void GivenIHavePressedTheWishlistButton()
        {
            wishlistPage.PressWishlistButton();
        }
        
        [Given(@"i have given my wishlist a name")]
        public void GivenIHaveGivenMyWishlistAName()
        {
            wishlistPage.TypeWishlistName("NewwishList");
        }
        
        [Given(@"i pressed the save wishlist button")]
        public void GivenIPressedTheSaveWishlistButton()
        {
            wishlistPage.SaveNewWishlist();
        }
        
        [Given(@"i have pressed on a item")]
        public void GivenIHavePressedOnAItem()
        {
            wishlistPage.PressNewItem();
        }
        
        [Given(@"i have added it to a wishlist")]
        public void GivenIHaveAddedItToAWishlist()
        {
            wishlistPage.AddItemToWishlist();
        }
        
        [Given(@"i go back to the wishlist page")]
        public void GivenIGoBackToTheWishlistPage()
        {
            wishlistPage.GoBackToWishlistPage();
        }
        
        [Given(@"i click on view")]
        public void GivenIClickOnView()
        {
            wishlistPage.ClickOnViewButton();
        }
        
        [Given(@"i delete the new wishlist")]
        public void GivenIDeleteTheNewWishlist()
        {
            wishlistPage.ClickOnDeleteButton();
        }
        
        [Then(@"i should see the new wishlist")]
        public void ThenIShouldSeeTheNewWishlist()
        {
            string result = wishlistPage.GetWishlistName();
            StringAssert.Contains(result, "NewwishList");
        }
        
        [Then(@"i should see the correct date")]
        public void ThenIShouldSeeTheCorrectDate()
        {
            string result = wishlistPage.GetDate();
            StringAssert.Contains(result, "2019-10-17");
        }
        
        [Then(@"i should see the item i added")]
        public void ThenIShouldSeeTheItemIAdded()
        {
            string result = wishlistPage.GetWishlistItem();
            StringAssert.Contains(result, "Printed Chiffon Dress");
        }
        
        [Then(@"i should not be able to see the wishlist")]
        public void ThenIShouldNotBeAbleToSeeTheWishlist()
        {
            string result = wishlistPage.GetWishlistName();
            StringAssert.DoesNotContain(result, "NewwishList");
        }
    }
}
