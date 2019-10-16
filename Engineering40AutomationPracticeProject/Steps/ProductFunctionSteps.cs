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
           Thread.Sleep(3000);
           Assert.AreEqual("Added to your wishlist.", womenPage.ErrorBox());
            loginPage.LogOut();
        }
        
        [Then(@"I should see the error message")]
        public void ThenIShouldSeeTheErrorMessage()
        {
            Thread.Sleep(3000);
            Assert.AreEqual("You must be logged in to manage your wishlist.", womenPage.ErrorBox());
        }
        
        [Then(@"I should see the selected items side by side")]
        public void ThenIShouldSeeTheSelectedItemsSideBySide()
        {
            Assert.AreEqual(4, womenPage.CompareInfo());
        }

        [Scope(Feature = "ProductFunction")]

        [AfterScenario]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
