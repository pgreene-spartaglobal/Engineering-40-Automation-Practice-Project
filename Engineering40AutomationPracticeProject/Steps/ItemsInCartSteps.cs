using System;
using TechTalk.SpecFlow;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class ItemsInCartSteps
    {
        [Given(@"I have added the items to my shopping cart")]
        public void GivenIHaveAddedTheItemsToMyShoppingCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have not added any items to my cart")]
        public void GivenIHaveNotAddedAnyItemsToMyCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Cart")]
        public void WhenIClickOnCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the Cart button")]
        public void WhenIClickOnTheCartButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the items in the Cart")]
        public void ThenIShouldSeeTheItemsInTheCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"there should be a Cart message\.")]
        public void ThenThereShouldBeACartMessage_()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
