Feature: CreateAccount
	In order to create an account
	I will need to enter a valid email address
	I will click the create account button
	I will then enter all the 'required' fields
	Then press create account 

Scenario: Email address not valid
	Given I am on the login page
	And I have entered an invalid email address
	And I have clicked create account
	Then I will see the appropriate error for incorrect email format
	
Scenario: Email address is valid
	Given I am on the login page
	And I have entered a valid email address
	And I have clicked create account
	Then I will go to the relevant page to create an account

Scenario:  All of the information is valid
	Given I have entered a valid email address and clicked create account
	And I have entered a first name
	And I have entered a last name
	And I have entered an address
	And I have entered a City
	And I have entered a valid state
	And I have entered a valid Postal code
	And I have entered a valid mobile phone
	And I have clicked create account
	Then I will be redirected to the account page

Scenario: Failure to enter first name
	Given I have entered a valid email address and clicked create account
	And I have not entered a first name
	And I have entered a last name
	And I have entered an address
	And I have entered a City
	And I have entered a valid state
	And I have entered a valid Postal code
	And I have entered a valid mobile phone
	And I have clicked create account
	Then I will see the appropriate error message for first name

Scenario: Failure to enter last name
	Given I have entered a valid email address and clicked create account
	And I have entered a first name
	And I have not entered a last name
	And I have entered an address
	And I have entered a City
	And I have entered a valid state
	And I have entered a valid Postal code
	And I have entered a valid mobile phone
	And I have clicked create account
	Then I will see the appropriate error message for last name

Scenario: Failure to enter address
	Given I have entered a valid email address and clicked create account
	And I have entered a first name
	And I have entered a last name
	And I have not entered an address
	And I have entered a City
	And I have entered a valid state
	And I have entered a valid Postal code
	And I have entered a valid mobile phone
	And I have clicked create account
	Then I will see the appropriate error message for address

Scenario: Failure to enter city
	Given I have entered a valid email address and clicked create account
	And I have entered a first name
	And I have entered a last name
	And I have entered an address
	And I have not entered a City
	And I have entered a valid state
	And I have entered a valid Postal code
	And I have entered a valid mobile phone
	And I have clicked create account
	Then I will see the appropriate error message for city

Scenario: Failure to enter state
	Given I have entered a valid email address and clicked create account
	And I have entered a first name
	And I have entered a last name
	And I have entered an address
	And I have entered a City
	And I have not entered a valid state
	And I have entered a valid Postal code
	And I have entered a valid mobile phone
	And I have clicked create account
	Then I will see the appropriate error message for state

Scenario: Failure to enter postal code
	Given I have entered a valid email address and clicked create account
	And I have entered a first name
	And I have entered a last name
	And I have entered an address
	And I have entered a City
	And I have entered a valid state
	And I have not entered a valid Postal code
	And I have entered a valid mobile phone
	And I have clicked create account
	Then I will see the appropriate error message for postal code

	
Scenario: Failure to enter phone number
	Given I have entered a valid email address and clicked create account
	And I have entered a first name
	And I have entered a last name
	And I have entered an address
	And I have entered a City
	And I have entered a valid state
	And I have entered a valid Postal code
	And I have not entered a valid mobile phone
	And I have clicked create account
	Then I will see the appropriate error message for mobile phone

Scenario: I have failed to enter any of the relevant fields
	Given I have entered a valid email address and clicked create account
	And I have not entered a first name
	And I have not entered a last name
	And I have not entered an address
	And I have not entered a city
	And I have not entered a valid state
	And I have not entered a valid Postal code
	And I have not entered a valid mobile phone
	And I have clicked create account
	Then I will see the appropriate error message for all failure
