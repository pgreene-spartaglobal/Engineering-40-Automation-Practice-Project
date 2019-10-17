using System;
using TechTalk.SpecFlow;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class FilterProductByCompositionSteps
    {
        [Given(@"I am on the Women Page")]
        public void GivenIAmOnTheWomenPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I tick the Cotton check box")]
        public void WhenITickTheCottonCheckBox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I tick the Polyester check box")]
        public void WhenITickThePolyesterCheckBox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I tick the Viscose check box")]
        public void WhenITickTheViscoseCheckBox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be showing Polyester items")]
        public void ThenTheResultShouldBeShowingPolyesterItems()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be showing Cotton items")]
        public void ThenTheResultShouldBeShowingCottonItems()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
