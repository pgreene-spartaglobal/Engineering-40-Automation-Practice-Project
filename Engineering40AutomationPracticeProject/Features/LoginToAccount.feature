Feature: LoginToAccount
	In order to log into the account
	I will neeed to enter a correct email address
	I will need to enter a correct password
	Then press login

Scenario: Correct Login Information
	Given I am on the login page
	And I have entered a correct password
	And I have entered a correct email address
	And I have clicked the submit button
	Then I will be redirected to the account page after login

Scenario: Incorrect Email Information
	Given I am on the login page
	And I have entered a correct password
	And I have entered an incorrect email address
	And I have clicked the submit button
	Then I will see the appropriate error message for email

Scenario: Incorrect Password Information
	Given I am on the login page
	And I have entered an incorrect password
	And I have entered a correct email address
	And I have clicked the submit button
	Then I will see the appropriate error message for password

Scenario: Successfully Logged In
	Given I am on the login page
	And I have entered a correct password 
	And I have entered a correct email address
	And I have clicked the submit button
	Then I will see my account name in the nav header

Scenario: Email address already being used
	Given I am on the login page
	And I have entered an email already registered
	And I have clicked create account
	Then I will see the appropriate error for email address in use

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