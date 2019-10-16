Feature: personalInfoCheck
	in order to login into my account
	as a user
	i want to see my personal infomation

Scenario: Check gender
	Given I have logged in
	And I pressed my personal information
	Then I should see appropriate gender

Scenario: Check first name
	Given I have logged in
	And I pressed my personal information
	Then I should see appropriate first name

Scenario: Check last name
	Given I have logged in
	And I pressed my personal information
	Then I should see appropriate last name

Scenario: Check Email address
	Given I have logged in
	And I pressed my personal information
	Then I should see appropriate email address
