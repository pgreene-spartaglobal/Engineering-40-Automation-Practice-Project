#Feature: Adding to the cart by hoovering on the product without clicking on it
Feature: AddToCart2
	As a user 
	when I enter the homepage and hover on the item 
	I want to be able to add it to the cart
	by clicking "add to cart" on a cart window.

Scenario: Adding to the cart 2
	Given I am on the homepage
	And I hover on the item
	When I press add to cart
	Then a pop-up window saying Successfully added to the cart should appear
