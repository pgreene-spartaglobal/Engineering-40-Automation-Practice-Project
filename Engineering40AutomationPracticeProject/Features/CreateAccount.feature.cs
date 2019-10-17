// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Engineering40AutomationPracticeProject.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CreateAccount")]
    public partial class CreateAccountFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CreateAccount.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CreateAccount", "\tIn order to create an account\r\n\tI will need to enter a valid email address\r\n\tI w" +
                    "ill click the create account button\r\n\tI will then enter all the \'required\' field" +
                    "s\r\n\tThen press create account ", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("All of the information is valid")]
        public virtual void AllOfTheInformationIsValid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All of the information is valid", null, ((string[])(null)));
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
 testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.And("I have entered a valid email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("I have clicked create account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("I have entered a first name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("I have entered a valid password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("I have entered a last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("I have entered an address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("I have entered a City", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("I have entered a valid state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("I have entered a valid Postal code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("I have entered a valid mobile phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("I have clicked submit information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.Then("I will be redirected to the account page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Feilure to enter a valid password")]
        public virtual void FeilureToEnterAValidPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Feilure to enter a valid password", null, ((string[])(null)));
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 25
 testRunner.Given("I have entered a valid email address and clicked create account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.And("I have entered a first name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("I have not entered a valid password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("I have entered a last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("I have entered an address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("I have entered a City", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("I have entered a valid state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("I have entered a valid Postal code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("I have entered a valid mobile phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("I have clicked submit information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.Then("I will see the appropriate error message for password format", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Failure to enter first name")]
        public virtual void FailureToEnterFirstName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Failure to enter first name", null, ((string[])(null)));
#line 37
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 38
 testRunner.Given("I have entered a valid email address and clicked create account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.And("I have not entered a first name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("I have entered a valid password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("I have entered a last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("I have entered an address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("I have entered a City", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("I have entered a valid state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("I have entered a valid Postal code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("I have entered a valid mobile phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("I have clicked submit information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.Then("I will see the appropriate error message for first name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Failure to enter last name")]
        public virtual void FailureToEnterLastName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Failure to enter last name", null, ((string[])(null)));
#line 50
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 51
 testRunner.Given("I have entered a valid email address and clicked create account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 52
 testRunner.And("I have entered a first name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("I have entered a valid password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("I have not entered a last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.And("I have entered an address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And("I have entered a City", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("I have entered a valid state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("I have entered a valid Postal code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("I have entered a valid mobile phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("I have clicked submit information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.Then("I will see the appropriate error message for last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Failure to enter address")]
        public virtual void FailureToEnterAddress()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Failure to enter address", null, ((string[])(null)));
#line 63
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 64
 testRunner.Given("I have entered a valid email address and clicked create account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
 testRunner.And("I have entered a first name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("I have entered a valid password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.And("I have entered a last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("I have not entered an address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("I have entered a City", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("I have entered a valid state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("I have entered a valid Postal code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("I have entered a valid mobile phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("I have clicked submit information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.Then("I will see the appropriate error message for address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Failure to enter city")]
        public virtual void FailureToEnterCity()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Failure to enter city", null, ((string[])(null)));
#line 76
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 77
 testRunner.Given("I have entered a valid email address and clicked create account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 78
 testRunner.And("I have entered a first name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("I have entered a valid password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("I have entered a last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("I have entered an address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("I have not entered a City", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("I have entered a valid state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.And("I have entered a valid Postal code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.And("I have entered a valid mobile phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.And("I have clicked submit information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.Then("I will see the appropriate error message for city", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Failure to enter state")]
        public virtual void FailureToEnterState()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Failure to enter state", null, ((string[])(null)));
#line 89
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 90
 testRunner.Given("I have entered a valid email address and clicked create account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 91
 testRunner.And("I have entered a first name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("I have entered a valid password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("I have entered a last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("I have entered an address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.And("I have entered a City", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And("I have not entered a valid state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.And("I have entered a valid Postal code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.And("I have entered a valid mobile phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And("I have clicked submit information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.Then("I will see the appropriate error message for state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Failure to enter postal code")]
        public virtual void FailureToEnterPostalCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Failure to enter postal code", null, ((string[])(null)));
#line 102
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 103
 testRunner.Given("I have entered a valid email address and clicked create account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 104
 testRunner.And("I have entered a first name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.And("I have entered a valid password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.And("I have entered a last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.And("I have entered an address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And("I have entered a City", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.And("I have entered a valid state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.And("I have not entered a valid Postal code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.And("I have entered a valid mobile phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.And("I have clicked submit information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.Then("I will see the appropriate error message for postal code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Failure to enter phone number")]
        public virtual void FailureToEnterPhoneNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Failure to enter phone number", null, ((string[])(null)));
#line 116
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 117
 testRunner.Given("I have entered a valid email address and clicked create account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 118
 testRunner.And("I have entered a first name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.And("I have entered a valid password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.And("I have entered a last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.And("I have entered an address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.And("I have entered a City", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.And("I have entered a valid state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.And("I have entered a valid Postal code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.And("I have not entered a valid mobile phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.And("I have clicked submit information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.Then("I will see the appropriate error message for mobile phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I have failed to enter any of the relevant fields")]
        public virtual void IHaveFailedToEnterAnyOfTheRelevantFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I have failed to enter any of the relevant fields", null, ((string[])(null)));
#line 129
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 130
 testRunner.Given("I have entered a valid email address and clicked create account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 131
 testRunner.And("I have not entered a first name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.And("I have not entered a valid password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.And("I have not entered a last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.And("I have not entered an address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.And("I have not entered a city", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.And("I have not entered a valid state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
 testRunner.And("I have not entered a valid Postal code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.And("I have not entered a valid mobile phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.And("I have clicked submit information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.Then("I will see the appropriate error message for all failure", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
