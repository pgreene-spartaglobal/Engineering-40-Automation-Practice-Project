Feature: FilterProductByColour
	In order to select the items I want
	As a user I want to be able to filter the result by different catagories

Scenario: Viewing the Beige items on Women Page
	Given I am on the Women Page
	When I tick the Beige check box
	Then the result should be showing items that is available in Beige

Scenario: Items are not available in Beige after selecting Beige
	Given I am on the Women Page
	When I tick the Beige check box
	Then the result should be showing items that is not available in Beige 

Scenario: Viewing the Orange items on T-Shirt Page
	Given I am on the T-Shirt Page
	When I tick the Orange check box
	Then the result should be showing items that is available in Orange 