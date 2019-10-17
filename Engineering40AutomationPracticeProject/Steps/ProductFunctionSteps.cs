using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace Engineering40AutomationPracticeProject.Pages
{
    [Binding]
    public class ProductFunctionSteps
    {
        private IWebDriver driver;
        private WomenPage womenPage;
        private LoginPage loginPage;

        [Scope(Feature = "ProductFunction")]
        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            womenPage = new WomenPage(driver);
        }

        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            loginPage.GoToPage();
            loginPage.Login();
        }

        [Given(@"That I am on the product page")]
        public void GivenThatIAmOnTheProductPage()
        {
            womenPage.GoToPage();
        }
        
        
        [When(@"I press on the wishlist button")]
        public void WhenIPressOnTheWishlistButton()
        {
            // checks for the add to wishlist button click
            womenPage.AddToWishList();            
        }
        
        [When(@"I press on the Add to compare button")]
        public void WhenIPressOnTheAddToCompareButton()
        {
            womenPage.CompareThreeItems();
            
        }
        
        [When(@"I press on the Compare button")]
        public void WhenIPressOnTheCompareButton()
        {
            womenPage.CompareBtn();
        }
        
        [Then(@"I should see the product on the wishlist")]
        public void ThenIShouldSeeTheProductOnTheWishlist()
        {
            
           Thread.Sleep(1000);
            // checks to see if the error box contains the message
           Assert.AreEqual("Added to your wishlist.", womenPage.ErrorBox());
            
        }
        
        [Then(@"I should see the error message")]
        public void ThenIShouldSeeTheErrorMessage()
        {
            //waits for 3 seconds
            Thread.Sleep(3000);
            // checks to see if the error box contains the message
            Assert.AreEqual("You must be logged in to manage your wishlist.", womenPage.ErrorBox());
        }
        
        [Then(@"I should see the selected items side by side")]
        public void ThenIShouldSeeTheSelectedItemsSideBySide()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(womenPage.ItemsAppear());
        }

        [Scope(Feature = "ProductFunction")]

        [AfterScenario]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
