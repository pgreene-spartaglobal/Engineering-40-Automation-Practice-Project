﻿Feature: Items In Cart
		As a User
		I want to be able to check the items in my cart
		So that I can proceed to the checkout.

Scenario: View items in Shopping cart
    	Given I am on the homepage
    	When I click on Cart
    	Then I should see the items in the Cart

Scenario: No items in Cart message
		Given I am on the homepage
		When I click on Cart
		Then there should be a Cart message. 