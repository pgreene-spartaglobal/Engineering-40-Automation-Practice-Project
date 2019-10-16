using System;
using TechTalk.SpecFlow;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class ContactCustomerServiceSteps
    {
        [Given(@"I am at the contact page")]
        public void GivenIAmAtTheContactPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have chosen the customer service as subject heading")]
        public void GivenIHaveChosenTheCustomerServiceAsSubjectHeading()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a valid email address")]
        public void GivenIHaveEnteredAValidEmailAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a message")]
        public void GivenIHaveEnteredAMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on send")]
        public void WhenIClickOnSend()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"It should display a message sent text")]
        public void ThenItShouldDisplayAMessageSentText()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
