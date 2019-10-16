Feature: AddToCart3
			As a user when I enter the homepage and hover on the item and 
			click "quick view" in the quick view window I want to be able to 
			click "add to cart" and add the item.

Scenario: Add to chart from homepage through hover on the item
		Given I am on the home page
		And  hover on the product
		And  I have click on the quickview 
		And I have added the quantity
		And I have picked the size
		And I have chosen the colour
		When I press the add to the cart button
		Then I should be able to to see the item added to the cart
