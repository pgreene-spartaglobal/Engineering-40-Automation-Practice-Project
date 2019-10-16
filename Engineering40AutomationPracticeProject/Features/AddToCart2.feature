Feature: Adding to the cart by hoovering on the product without clicking on it
	As a user 
	when I enter the homepage and hover on the item 
	I want to be able to add it to the cart
	by clicking "add to cart" on a cart window.

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
