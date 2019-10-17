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
        ProductPage productPage;

        [Scope(Feature = "FilterProductByColour")]
        [BeforeScenario]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Scope(Feature = "FilterProductByColour")]
        [AfterScenario]
        public void TearDown()
        {
            driver.Close();
        }

        [Scope(Feature = "FilterProductByColour")]
        [Given(@"I am on the Women Page")]
        public void GivenIAmOnTheWomenPage()
        {
            productPage = new WomenPage(driver);
            productPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByColour")]
        [Given(@"I am on the Brouses Page")]
        public void GivenIAmOnTheBrousesPage()
        {
            productPage = new BlousesPage(driver);
            productPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByColour")]
        [Given(@"I am on the T-Shirt Page")]
        public void GivenIAmOnTheT_ShirtPage()
        {
            productPage = new TShirtPage(driver);
            productPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByColour")]
        [Given(@"I am on the Dresses Page")]
        public void GivenIAmOnTheDressesPage()
        {
            productPage = new DressesPage(driver);
            productPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByColour")]
        [Given(@"I am on the Casual Dresses Page")]
        public void GivenIAmOnTheCasualDressesPage()
        {
            productPage = new CasualDressesPage(driver);
            productPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByColour")]
        [When(@"I tick the Beige check box")]
        public void WhenITickTheBeigeCheckBox()
        {
            productPage.ClickBiege();
        }

        [Scope(Feature = "FilterProductByColour")]
        [When(@"I tick the Green check box")]
        public void WhenITickTheGreenCheckBox()
        {
            productPage.ClickGreen();
        }

        [Scope(Feature = "FilterProductByColour")]
        [When(@"I tick the Orange check box")]
        public void WhenITickTheOrangeCheckBox()
        {
            productPage.ClickOrange();
        }

        [Scope(Feature = "FilterProductByColour")]
        [When(@"I tick the White check box")]
        public void WhenITickTheWhiteCheckBox()
        {
            productPage.ClickWhite();
        }

        [Scope(Feature = "FilterProductByColour")]
        [Then(@"the result should be showing items that is available in Beige")]
        public void ThenTheResultShouldBeShowingItemsThatIsAvailableInBeige()
        {
            //Get the css value of beige
            string beige = productPage.GetBiegeColour();
            //Check if the fourth item available in Beige
            bool result = productPage.ContainColour(beige, 3);
            Assert.AreEqual(true, result);
        }

        [Scope(Feature = "FilterProductByColour")]
        [Then(@"the result should be showing items that is available in Orange")]
        public void ThenTheResultShouldBeShowingItemsThatIsAvailableInOrange()
        {
            //Get the colour string of Orange
            string orange = productPage.GetOrangeColour();
            //check if the first item contain orange
            bool result = productPage.ContainColour(orange, 0);
            //compare result
            Assert.AreEqual(true, result);
        }

        [Scope(Feature = "FilterProductByColour")]
        [Then(@"the First item from the result should not be available in Beige")]
        public void ThenTheFirstItemFromTheResultShouldNotBeAvailableInBeige()
        {
            //Get the string for beige
            string beige = productPage.GetBiegeColour();
            //check if the first item available in Beige
            bool result = productPage.ContainColour(beige, 0);
            Assert.AreNotEqual(true, result);
        }

        [Scope(Feature = "FilterProductByColour", Tag = "dressesPage")]
        [Then(@"the result should be showing items that is available in Green")]
        public void ThenTheResultShouldBeShowingItemsThatIsAvailableInGreen()
        {
            string green = productPage.GetGreenColour();
            bool result = productPage.ContainColour(green, 4);
            Assert.AreEqual(true, result);
        }

        [Scope(Feature = "FilterProductByColour")]
        [Then(@"the First item from the result should not be available in Green")]
        public void ThenTheFirstItemFromTheResultShouldNotBeAvailableInGreen()
        {
            string green = productPage.GetGreenColour();
            bool result = productPage.ContainColour(green, 0);
            Assert.AreNotEqual(true, result);
        }

        [Scope(Scenario = "Viewing the White items on Brouses Page")]
        [Then(@"the result should be showing items that is available in White")]
        public void ThenTheResultShouldBeShowingItemsThatIsAvailableInWhite()
        {
            string white = productPage.GetWhiteColour();
            bool result = productPage.ContainColour(white, 0);
            Assert.AreEqual(true, result);
        }

        [Scope(Feature = "FilterProductByColour")]
        [Given(@"I am on the Evening Dresses Page")]
        public void GivenIAmOnTheEveningDressesPage()
        {
            productPage = new EveningDresses(driver);
            productPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByColour")]
        [When(@"I tick the Pink check box")]
        public void WhenITickThePinkCheckBox()
        {
            productPage.ClickPink();
        }

        [Scope(Feature = "FilterProductByColour")]
        [Then(@"the result should be showing items that is available in Pink")]
        public void ThenTheResultShouldBeShowingItemsThatIsAvailableInPink()
        {
            string pink = productPage.GetPinkColour();
            bool result = productPage.ContainColour(pink, 0);
            Assert.AreEqual(true, result);
        }

        [Scope(Feature = "FilterProductByColour")]
        [Given(@"I am on the Summer Dresses Page")]
        public void GivenIAmOnTheSummerDressesPage()
        {
            productPage = new SummerDresses(driver);
            productPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByColour")]
        [Then(@"the First item from the result should not be available in White")]
        public void ThenTheFirstItemFromTheResultShouldNotBeAvailableInWhite()
        {
            string white = productPage.GetWhiteColour();
            bool result = productPage.ContainColour(white, 0);
            Assert.AreNotEqual(true, result);
        }

        [Scope(Feature = "FilterProductByColour")]
        [When(@"I tick the Yellow check box")]
        public void WhenITickTheYellowCheckBox()
        {
            productPage.ClickYellow();
        }

        [Scope(Feature = "FilterProductByColour")]
        [Then(@"the result should be showing items that is available in Yellow")]
        public void ThenTheResultShouldBeShowingItemsThatIsAvailableInYellow()
        {
            string yellow = productPage.GetYellowColour();
            bool result = productPage.ContainColour(yellow, 0);
            Assert.AreEqual(true, result);
        }
    }
}
