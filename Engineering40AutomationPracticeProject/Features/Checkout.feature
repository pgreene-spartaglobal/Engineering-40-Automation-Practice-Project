Feature: Checkout
	As a user
	I want to be able to checkout with my items and pay
	So that I can receive them.

Scenario: Succesful Purchase using bank wire
	Given I am on the Home Page
    And I have added at least one item to the shopping cart
    And I am on the Shopping-Cart Summary page
    And I clicked on the Proceed to checkout button
    And I am signed in
    And I have a valid shipping address
    And I have a valid billing address
    And I clicked on the Proceed to checkout button on Addresses page
    And I have agreed to the terms of service on the shipping page
    And I clicked on the Proceed to checkout button on Shipping page
    And I clicked on Pay by bank wire button
    When I clicked on I confirm my order button on Order Summary page
    Then I should see the Order Confirmation page



