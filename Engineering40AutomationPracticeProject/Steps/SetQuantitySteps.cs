using System;
using TechTalk.SpecFlow;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class SetQuantitySteps
    {
        [Given(@"I am on the checkout page")]
        public void GivenIAmOnTheCheckoutPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the pluss button")]
        public void WhenIClickThePlussButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see Quantity increase")]
        public void ThenIShouldSeeQuantityIncrease()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
