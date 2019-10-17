Feature: AccessSpecialOffers
	As a user, I want to be able to view Special Offers

@mytag
Scenario: View special offer
	Given I am in the home page
	When I click on the special offer page
	Then It should show me the special offers

Scenario: Compare special offer and original price 
	Given I am in the special offer page
	When I compare the original and the new price
	Then The new price should be less than the original price

