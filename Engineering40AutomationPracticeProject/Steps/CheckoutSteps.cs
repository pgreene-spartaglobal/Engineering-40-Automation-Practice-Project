using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Engineering40AutomationPracticeProject.Pages;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class CheckoutSteps
    {
        private IWebDriver driver;
        private Homepage homepage;
        private CartPage cartPage;
        private ProductPage product;
        private ItemsInCartSteps itemsInCartSteps;
        private ShoppingCartSummaryPage summaryPage;
        private CheckoutSignInPage checkoutSignInPage;
        private CheckoutAddressPage checkoutAddressPage;
        private CheckoutShippingPage checkoutShippingPage;
        private CheckoutPaymentPage checkoutPaymentPage;
        private PayByBankWirePage payByBankWire;
        private PayByBankWireOrderConfirmationPage payByBankWireOrderConfirmationPage;

        //[Scope(Feature = "CheckoutSteps")]
        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homepage = new Homepage(driver);
            cartPage = new CartPage(driver);
            product = new ProductPage(driver);
            summaryPage = new ShoppingCartSummaryPage(driver);
            checkoutSignInPage = new CheckoutSignInPage(driver);
            checkoutAddressPage = new CheckoutAddressPage(driver);
            checkoutShippingPage = new CheckoutShippingPage(driver);
            checkoutPaymentPage = new CheckoutPaymentPage(driver);
            payByBankWire = new PayByBankWirePage(driver);
            payByBankWireOrderConfirmationPage = new PayByBankWireOrderConfirmationPage(driver);
        }

        [Given(@"I am on the Home Page")]
        public void GivenIAmOnTheHomePage()
        {
            homepage.GoToPage();
        }
        [Given(@"I have added at least one item to the shopping cart")]
        public void GivenIHaveAddedAtLeastOneItemToTheShoppingCart()
        {
            homepage.GoToProduct();
            product.clearQuant();
            product.ChooseQuant("5");
            product.ChooseSize("L");
            product.AddToCart1();
        }
        
        [Given(@"I am on the Shopping-Cart Summary page")]
        public void GivenIAmOnTheShopping_CartSummaryPage()
        {
            cartPage.ProcessButton();
            //summaryPage.ShopingCartSummaryHeaderResult();
        }
        
        [Given(@"I clicked on the Proceed to checkout button")]
        public void GivenIClickedOnTheProceedToCheckoutButton()
        {
            summaryPage.ProceedToCheckOutButtonSummary();
        }
        
        [Given(@"I am signed in")]
        public void GivenIAmSignedIn()
        {
            checkoutSignInPage.FillUserNameSignIn("nbalaisyte@spartaglobal.com");
            checkoutSignInPage.FillPasswordSignIn("Sparta2020");
            checkoutSignInPage.SignInButton();
            checkoutSignInPage.AddressesHeaderResult();
        }
        
        [Given(@"I have a valid shipping address")]
        public void GivenIHaveAValidShippingAddress()
        {
            checkoutAddressPage.DeliveryAddressFieldResult();
        }
        
        [Given(@"I have a valid billing address")]
        public void GivenIHaveAValidBillingAddress()
        {
            checkoutAddressPage.BillingAddressFieldResult();
        }
        
        [Given(@"I clicked on the Proceed to checkout button on Addresses page")]
        public void GivenIClickedOnTheProceedToCheckoutButtonOnAddressesPage()
        {
            checkoutAddressPage.ProceedToCheckOutButtonAddress();
        }
        
        [Given(@"I have agreed to the terms of service on the shipping page")]
        public void GivenIHaveAgreedToTheTermsOfServiceOnTheShippingPage()
        {
            checkoutShippingPage.CheckBoxButtonShipping();
        }
        
        [Given(@"I clicked on the Proceed to checkout button on Shipping page")]
        public void GivenIClickedOnTheProceedToCheckoutButtonOnShippingPage()
        {
            checkoutShippingPage.ProceedToCheckOutButtonShipping();
        }
        
        [Given(@"I clicked on Pay by bank wire button")]
        public void GivenIClickedOnPayByBankWireButton()
        {
            checkoutPaymentPage.PayByBankWireButton();
        }
        
        [When(@"I clicked on I confirm my order button on Order Summary page")]
        public void WhenIClickedOnIConfirmMyOrderButtonOnOrderSummaryPage()
        {
            payByBankWire.PayByBankWireButton();
        }
        
        [Then(@"I should see the Order Confirmation page")]
        public void ThenIShouldSeeTheOrderConfirmationPage()
        {
            Assert.AreEqual("ORDER CONFIRMATION", payByBankWireOrderConfirmationPage.OrderConfirmationResult());
        }

        //[Scope(Feature = "CheckoutSteps")]
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
        }
    }
}
