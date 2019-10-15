Feature: Set Delivery Address Checkout Section
	As a user
	I want to be able to add a delivery address
	So that I can receive the ordered items.

Scenario: Add a new new delivery address
    Given I am on the Addresses page In Checkout Section
    When I click on Add a new address
    Then I should see Your Addresses page

Scenario: Update a delivery address
    Given I am on the Addresses page In Checkout Section
    When I click on Update button
    Then I should see Your Addresses page