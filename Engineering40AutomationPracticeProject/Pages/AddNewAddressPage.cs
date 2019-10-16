using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Engineering40AutomationPracticeProject.Pages
{
    class AddNewAddressPage
    {

        [FindsBy(How = How.Name, Using = "firstname")]
        private IWebElement FirstNameField;

        [FindsBy(How = How.Name, Using = "lastname")]
        private IWebElement LastnameField;

        [FindsBy(How = How.Name, Using = "address1")]
        private IWebElement Address1Field;

        [FindsBy(How = How.Name, Using = "city")]
        private IWebElement CityField;

        [FindsBy(How = How.Id, Using = "id_state")]
        private IWebElement StateField;
        SelectElement stateSelect;// = new SelectElement(StateField);

        [FindsBy(How = How.Name, Using = "postcode")]
        private IWebElement PostcodeField;

        [FindsBy(How = How.Name, Using = "id_country")]
        private IWebElement CountryIdField;

        [FindsBy(How = How.Name, Using = "phone")]
        private IWebElement PhoneIdField;

        [FindsBy(How = How.Name, Using = "phone_mobile")]
        private IWebElement MobileIdField;

        [FindsBy(How = How.ClassName, Using = "page-heading")]
        private IWebElement pageHeading;

        [FindsBy(How = How.ClassName, Using = "page-subheading")]
        private IWebElement pagesubHeading;



        public void FillFirstNameField(string firstname)
        {
            FirstNameField.SendKeys(firstname);
        }

        public void FillLastNameField(string lastname)
        {
            LastnameField.SendKeys(lastname);
        }

        public void FillAddressField(string address)
        {
            Address1Field.SendKeys(address);
        }

        public void FillCityField(string citytext)
        {
            CityField.SendKeys(citytext);
        }

        public void SelectStateField(string state)
        {
            stateSelect = new SelectElement(StateField);
            stateSelect.SelectByText(state);
        }

        public void FillPostcodeField(string postcode)
        {
            PostcodeField.SendKeys(postcode);
        }

        public void SelectedcountryField(string country)
        {
            //FirstNameField.SendKeys(firstname);
        }

        public void FillPhoneField(string phone)
        {
            PhoneIdField.SendKeys(phone);
        }

        public void FillMobileField(string mobile)
        {
            MobileIdField.SendKeys(mobile);
        }

        public string GetSubpageHeader()
        {
            return pagesubHeading.Text;
        }
    }
}
