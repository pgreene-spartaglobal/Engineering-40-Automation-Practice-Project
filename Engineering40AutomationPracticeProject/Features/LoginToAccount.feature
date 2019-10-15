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
	Then I will log in

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


