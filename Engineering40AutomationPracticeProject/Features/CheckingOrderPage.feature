Feature: CheckingOrdersPage
	Checking the orders or the order page

Scenario: View orders page
	Given I have logged into the account
	And I have clicked view orders
	Then I should see the orders page

Scenario: Check orders sorting by price
	Given I have logged into the account
	And I have clicked view orders
	And I have clicked sort price
	Then The orders should be ordered by price being minimum first

Scenario: Check order details
	Given I have logged into the account
	And I have clicked view orders
	And I have clicked view details
	Then I should be on the correct page for that order

Scenario: Send mail
	Given I have logged into the account
	And I have clicked view orders
	And I have clicked view details
	And I have selected the product
	And I have wrote a message
	And I have clicked send
	Then I should see a successful message sent

Scenario: Reorder item
	Given I have logged into the account
	And I have clicked view orders
	And I have clicked reorder
	Then I should be on the checkout page

