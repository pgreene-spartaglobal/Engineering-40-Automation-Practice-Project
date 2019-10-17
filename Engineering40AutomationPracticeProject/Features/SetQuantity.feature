Feature: SetQuantity

Scenario: Add Quantity
Given I am on the checkout page
And I have added a product to the Basket
And I have navigated to the Checkout area
When I click the plus button
Then I should see Quantity increase

Scenario: Minus Quantity
Given I am on the checkout page
And I have added a product to the Basket
And I have navigated to the Checkout area
When I click the minus button
Then I should see Quantity decrease