Feature: Checkout
	As a user
	I want to be able to checkout with my items and pay
	So that I can receive them.

Scenario: Succesful Purchase using bank wire
    Given I have added at least one item to the shopping cart
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

Scenario: Succesful Purchase using check
    Given I have added at least one item to the shopping cart
    And I am on the Shopping-Cart Summary page
    And I clicked on the Proceed to checkout button
    And I am signed in
    And I have a valid shipping address
    And I have a valid billing address
    And I clicked on the Proceed to checkout button on Addresses page
    And I have agreed to the terms of service on the shipping page
    And I clicked on the Proceed to checkout button on Shipping page
    And I clicked on Pay by check button on the Payment Method page
    When I clicked on I confirm my order button on Order Summary page
    Then I should see the Order Confirmation page

Scenario: Succesful Purchase using check
    Given I have added at least one item to the shopping cart
    And I am on the Shopping-Cart Summary page
    And I clicked on the Proceed to checkout button
    And I am not signed in
    And I have entered a valid email address
    And I have entered a valid password
    And I have clicked on the Sign in button on the Authentication page
    And I have a valid shipping address
    And I have a valid billing address
    And I clicked on the Proceed to checkout button on Addresses page
    And I have agreed to the terms of service on the shipping page
    And I clicked on the Proceed to checkout button on Shipping page
    And I clicked on Pay by check button on the Payment Method page
    When I clicked on I confirm my order button on Order Summary page
    Then I should see the Order Confirmation page

Scenario: Succesful Purchase using bank wire
    Given I have added at least one item to the shopping cart
    And I am on the Shopping-Cart Summary page
    And I clicked on the Proceed to checkout button
    And I am not signed in
    And I have entered a valid email address
    And I have entered a valid password
    And I have clicked on the Sign in button on the Authentication page
    And I have a valid shipping address
    And I have a valid billing address
    And I clicked on the Proceed to checkout button on Addresses page
    And I have agreed to the terms of service on the shipping page
    And I clicked on the Proceed to checkout button on Shipping page
    And I clicked on Pay by check button on the Payment Method page
    When I clicked on I confirm my order button on Order Summary page
    Then I should see the Order Confirmation page

Scenario: Wanting to make a purchase, but do not have an account
    Given I have added at least one item to the shopping cart
    And I am on the Shopping-Cart Summary page
    And I clicked on the Proceed to checkout button
    And I do not have an account
    And I have entered a valid email address on Create an Account section
    When I have clicked on the Create an account button on the Authentication page
    Then I should see the Create an Account page

Scenario: Wanting to make a purchase, but typed an invalid password
    Given I have added at least one item to the shopping cart
    And I am on the Shopping-Cart Summary page
    And I clicked on the Proceed to checkout button
    And I am not signed in
    And I have entered a valid email address
    And I have entered a invalid password
    When I have clicked on the Sign in button on the Authentication page
    Then I should receive an error called Authentication failed

Scenario: Wanting to make a purchase, but typed an invalid email address
    Given I have added at least one item to the shopping cart
    And I am on the Shopping-Cart Summary page
    And I clicked on the Proceed to checkout button
    And I am not signed in
    And I have entered a invalid email address
    And I have entered a valid password
    When I have clicked on the Sign in button on the Authentication page
    Then I should receive an error called Authentication failed