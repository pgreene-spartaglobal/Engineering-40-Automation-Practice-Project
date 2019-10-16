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