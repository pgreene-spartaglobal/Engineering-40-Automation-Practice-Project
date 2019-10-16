using System;
using TechTalk.SpecFlow;

namespace Engineering40AutomationPracticeProject
{
    [Binding]
    public class FilterProductByColourSteps
    {
        [Given(@"I am on the Women Page")]
        public void GivenIAmOnTheWomenPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I tick the Beige check box")]
        public void WhenITickTheBeigeCheckBox()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be showing items in Beige colour only")]
        public void ThenTheResultShouldBeShowingItemsInBeigeColourOnly()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
