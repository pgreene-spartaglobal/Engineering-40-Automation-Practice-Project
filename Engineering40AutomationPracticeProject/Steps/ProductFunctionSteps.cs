using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Engineering40AutomationPracticeProject.Pages
{
    [Binding]
    public class ProductFunctionSteps
    {
        [Given(@"That I am on the product page")]
        public void GivenThatIAmOnTheProductPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have selected a product")]
        public void GivenIHaveSelectedAProduct()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press on the wishlist button")]
        public void WhenIPressOnTheWishlistButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press on the Add to compare button")]
        public void WhenIPressOnTheAddToCompareButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press on the Compare button")]
        public void WhenIPressOnTheCompareButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the product on the wishlist")]
        public void ThenIShouldSeeTheProductOnTheWishlist()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the error message")]
        public void ThenIShouldSeeTheErrorMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the selected items side by side")]
        public void ThenIShouldSeeTheSelectedItemsSideBySide()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
