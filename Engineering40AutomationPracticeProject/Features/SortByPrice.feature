Feature: SortByPrice
As a user I want to be able to filter the result by price range

Scenario: Filter by price lowest first
	Given I am on the women page
	When  I click on price lowest first
	Then It should display items in ascending order by price

Scenario: Filter by price highest first
	Given I am on the women page
	When  I click on price highest first
	Then It should not display items in descending order by price

Scenario: Filter by product by A-Z
	Given I am on the women page
	When  I click on product by A-Z
	Then It should not display items in ascending order by product

Scenario: Filter by product by Z-A
	Given I am on the women page
	When  I click on product by Z-A
	Then It should not display items in descending order by product

Scenario: Filter by In-Stock
	Given I am on the women page
	When  I click on in-stock
	Then It should display items that are in stock

Scenario: Filter by reference - Lowest First
	Given I am on the women page
	When  I click on reference - Lowest First
	Then It should not display items in ascending order by reference

Scenario: Filter by reference - Highest First
	Given I am on the women page
	When  I click on reference - Highest First
	Then It should not display items in descending order by reference