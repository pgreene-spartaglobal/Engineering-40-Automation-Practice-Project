Feature: Items In Cart
		As a User
		I want to be able to check the items in my cart
		So that I can proceed to the checkout.


Scenario: View items in Shopping cart

    	Given I have added the items to my shopping cart
    	When I click on Cart
    	Then I should see the items in the Cart

Scenario: No items in Cart message

		Given I have not added any items to my cart
		When I click on the Cart button
		Then there should be a Cart message. 