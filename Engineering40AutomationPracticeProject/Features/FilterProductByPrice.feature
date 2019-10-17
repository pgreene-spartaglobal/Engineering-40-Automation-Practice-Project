Feature: FilterProductByPrice
	In order to select the items I want within the price range
	As a user
	I want to be able to filter the result by price


Scenario: Price of the products on Women Page is out of range
	Given I am on the Women Page
	When I move the head of the slider to $34.13
	Then result should be showing products that is below $34.13

Scenario: Price of the products on Dresses Page is out of range
	Given I am on the Dresses Page
	When I move the head of the slider to $34.13
	Then result should be showing products that is below $34.13


Scenario: Price of the products on T-Shirt Page is out of range
	Given I am on the T-Shirt Page
	When I move the head of the slider to $34.13
	Then result should be showing products that is below $34.13


Scenario: Price of the products on Causal Dresses Page is out of range
	Given I am on the Casual Dresses Page
	When I move the head of the slider to $34.13
	Then result should be showing products that is below $34.13


Scenario: Price of the products on Summer Dresses Page is out of range
	Given I am on the Summer Dresses Page
	When I move the head of the slider to $34.13
	Then result should be showing products that is below $34.13


Scenario: Price of the products on Evening Dresses Page is out of range
	Given I am on the Evening Dresses Page
	When I move the head of the slider to $34.13
	Then result should be showing products that is below $34.13