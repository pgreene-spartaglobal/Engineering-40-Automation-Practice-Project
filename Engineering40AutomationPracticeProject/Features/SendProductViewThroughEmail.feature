Feature: SendProductViewThroughEmail
	As a user, I want to be able to send details about a product I like to 
	family and friends

@SendProductDetailsThroughEmail
Scenario: Send product details through email
	Given I am in a product view page
	When I click on the send to a friend link
	And I have entered a name 
	And I have entered an invalid email 
	And I click the send button 
	Then The mail should not be sent 
