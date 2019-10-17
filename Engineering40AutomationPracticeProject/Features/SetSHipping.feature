Feature: SetShipping

Scenario: Select Shipping Option
	Given I am on the Shipping Page
	And I am signed in
	And I have added an item to the basket
	And I have agreed to terms and conditions
	And I have selected the shipping option
	When I click proceed to checkout
	Then I should be able to choose my payment option
