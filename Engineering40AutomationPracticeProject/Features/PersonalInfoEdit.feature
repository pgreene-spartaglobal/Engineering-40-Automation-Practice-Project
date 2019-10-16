Feature: PersonalInfoEdit
	in order to login into my account
	as a user
	i want to see my personal infomation and edit it

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

Scenario: Change first name
	Given I have logged in
	And I pressed my personal information
	And I entered my new first name
	And I have entered my current password
	And I pressed the save button
	And I back on my account
	And I pressed my personal information
	Then I should see the new first name

	
Scenario: Change secound name
	Given I have logged in
	And I pressed my personal information
	And I entered my new last name
	And I have entered my current password
	And I pressed the save button
	And I back on my account
	And I pressed my personal information
	Then I should see the new last name

Scenario: Change email address
	Given I have logged in
	And I pressed my personal information
	And I entered my new email address
	And I have entered my current password
	And I pressed the save button
	And I back on my account
	And I pressed my personal information
	Then I should see the new email address


