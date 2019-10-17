Feature: FilterProductByComposition
	In order to select the items I want
	As a user
	I want to be able to filter the result by different composition

Scenario: Viewing the Cotton items
	Given I am on the Women Page
	When I tick the Cotton check box
	Then the result should be showing Polyester items

Scenario: Viewing the Polyester items
	Given I am on the Women Page
	When I tick the Polyester check box
	Then the result should be showing Cotton items

Scenario: Viewing the Viscose items
	Given I am on the Women Page
	When I tick the Viscose check box
	Then the result should be showing Cotton items