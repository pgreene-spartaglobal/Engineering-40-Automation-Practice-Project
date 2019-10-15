Feature: ProductFunction
As a user
I want to be able to add products to the wishlist
I want to be able to compare products

Scenario: Valid Add to the Wishlist 
	Given That I am on the product page
	And I am logged in
	And I have selected a product
	When I press on the wishlist button
	Then I should see the product on the wishlist

Scenario: Invalid Add to the Wishlist 
	Given That I am on the product page
	And I have selected a product
	When I press on the wishlist button
	Then I should see the error message

Scenario: Compare three products
	Given That I am on the product page
	And I have selected a product
	When I press on the Add to compare button
	And I press on the Compare button
	Then I should see the selected items side by side