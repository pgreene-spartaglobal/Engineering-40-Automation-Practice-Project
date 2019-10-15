Feature: Update Billing Addresses Checkout Section
	As a user
	I want to be able to edit my billing address
	So that I can pay for the ordered items.

Scenario: Update a billing address
    Given I am on the Addresses page In Checkout Section
    When I click on Update button
    Then I should see Your Addresses page