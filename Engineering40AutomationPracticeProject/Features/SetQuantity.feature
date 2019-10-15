Feature: SetQuantity

Scenario: Set Quantity
Given I am on the checkout page
And I have added a product to the Basket
And I have navigated to the Checkout area
When I click the plus button
Then I should see Quantity increase