Feature: FilterProductByColour
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Viewing the Beige items
	Given I am on the Women Page
	When I tick the Beige check box
	Then the result should be showing items in Beige colour only
