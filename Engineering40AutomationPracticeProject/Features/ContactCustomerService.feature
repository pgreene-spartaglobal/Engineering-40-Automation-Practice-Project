Feature: ContactCustomerService
As a user, I want to be able to contact Customer Service
	

@mytag
Scenario: Send message to customer service
	Given I am at the contact page
	And I have chosen the customer service as subject heading
	And I have entered a valid email address
	And I have entered a message 
	When I click on send
	Then It should display a message sent text

Scenario: Show error when invalid email is entered
	Given I am at the contact page
	And I have chosen the customer service as subject heading
	And I have not given a vaild email address
	When I click on send
	Then It should display an appropriate no email error message


Scenario: Show error when message box is empty
	Given I am at the contact page
	And I have chosen the customer service as subject heading
	And I have entered a valid email address
	When I click on send
	Then It should display an appropriate error message 

Scenario: Add a file to the Message
	Given I am at the contact page
	When I click on the add file button 
	Then It should not show a file explorer so I can choose file to add

