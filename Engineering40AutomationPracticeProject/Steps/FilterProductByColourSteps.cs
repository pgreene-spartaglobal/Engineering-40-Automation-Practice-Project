using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Engineering40AutomationPracticeProject
{
    [Binding]
    public class FilterProductByColourSteps
    {
        IWebDriver driver;
        TShirtPage tShirtPage;
        WomenPage womenPage;
        DressesPage dressesPage;

        [BeforeScenario]
        public void Setup()
        {
            //driver.Dispose();
            driver = new ChromeDriver();
        }

        [Scope(Feature = "FilterProductByColour")]
        [Given(@"I am on the Women Page")]
        public void GivenIAmOnTheWomenPage()
        {
            womenPage = new WomenPage(driver);
            womenPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByColour")]
        [When(@"I tick the Beige check box")]
        public void WhenITickTheBeigeCheckBox()
        {
            womenPage.ClickBiege();
        }

        [Scope(Feature = "FilterProductByColour")]
        [Then(@"the result should be showing items that is available in Beige")]
        public void ThenTheResultShouldBeShowingItemsThatIsAvailableInBeige()
        {
            //Get the css value of beige
            string beige = womenPage.GetBiegeColour();
            //Check if the fourth item available in Beige
            bool result = womenPage.ContainColour(beige, 3);
            Assert.AreEqual(true, result);
        }

        [Scope(Feature = "FilterProductByColour")]
        [Given(@"I am on the T-Shirt Page")]
        public void GivenIAmOnTheT_ShirtPage()
        {
            tShirtPage = new TShirtPage(driver);
            tShirtPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByColour")]
        [When(@"I tick the Orange check box")]
        public void WhenITickTheOrangeCheckBox()
        {
            tShirtPage.ClickOrange();
        }

        [Scope(Feature = "FilterProductByColour")]
        [Then(@"the result should be showing items that is available in Orange")]
        public void ThenTheResultShouldBeShowingItemsThatIsAvailableInOrange()
        {
            //Get the colour string of Orange
            string orange = tShirtPage.GetOrangeColour();
            //check if the first item contain orange
            bool result = tShirtPage.ContainColour(orange, 0);
            //compare result
            Assert.AreEqual(true, result);
        }

        [Scope(Feature = "FilterProductByColour")]
        [Then(@"the result should be showing items that is not available in Beige")]
        public void ThenTheResultShouldBeShowingItemsThatIsNotAvailableInBeige()
        {
            //Get the string for beige
            string beige = womenPage.GetBiegeColour();
            //check if the first item available in Beige
            bool result = womenPage.ContainColour(beige, 0);
            Assert.AreNotEqual(true, result);
        }

        [Scope(Feature = "FilterProductByColour")]
        [When(@"I tick the Green check box")]
        public void WhenITickTheGreenCheckBox()
        {
            dressesPage.ClickGreen();
        }

        [Scope(Feature = "FilterProductByColour", Tag = "dressesPage")]
        [Then(@"the result should be showing items that is available in Green")]
        public void ThenTheResultShouldBeShowingItemsThatIsAvailableInGreen()
        {
            string green = dressesPage.GetGreenColour();
            bool result = dressesPage.ContainColour(green, 4);
            Assert.AreEqual(true, result);
        }

        [Scope(Feature = "FilterProductByColour", Tag = "dressesPage")]
        [Then(@"the result should be showing items that is not available in Green")]
        public void ThenTheResultShouldBeShowingItemsThatIsNotAvailableInGreen()
        {
            string green = dressesPage.GetGreenColour();
            bool result = dressesPage.ContainColour(green, 0);
            Assert.AreNotEqual(true, result);
        }

        [Scope(Feature = "FilterProductByColour")]
        [Given(@"I am on the Dresses Page")]
        public void GivenIAmOnTheDressesPage()
        {
            dressesPage = new DressesPage(driver);
            dressesPage.GoToPage();
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
