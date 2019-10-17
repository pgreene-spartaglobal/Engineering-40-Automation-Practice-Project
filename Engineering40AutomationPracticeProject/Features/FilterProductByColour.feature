Feature: FilterProductByColour
	In order to select the items I want
	As a user I want to be able to filter the result by different catagories

Scenario: Viewing the Beige items on Women Page
	Given I am on the Women Page
	When I tick the Beige check box
	Then the result should be showing items that is available in Beige

Scenario: Items are not available in Beige after selecting Beige
	Given I am on the Women Page
	When I tick the Beige check box
	Then the First item from the result should not be available in Beige 

Scenario: Viewing the Orange items on T-Shirt Page
	Given I am on the T-Shirt Page
	When I tick the Orange check box
	Then the result should be showing items that is available in Orange

@dressesPage
Scenario: Viewing the Green items on Dresses Page
	Given I am on the Dresses Page
	When I tick the Green check box
	Then the result should be showing items that is available in Green

@dressesPage
Scenario: Items are not available in Green after selecting Green
	Given I am on the Dresses Page
	When I tick the Green check box
	Then the First item from the result should not be available in Green

@dressesPage
Scenario: Viewing the White items on Brouses Page
	Given I am on the Brouses Page
	When I tick the White check box
	Then the result should be showing items that is available in White

@dressesPage
Scenario: Viewing the Orange items on Casual Dresses Page
	Given I am on the Casual Dresses Page
	When I tick the Orange check box
	Then the result should be showing items that is available in Orange

@dressesPage
Scenario: Viewing the Pink items on Evening Dresses Page
	Given I am on the Evening Dresses Page
	When I tick the Pink check box
	Then the result should be showing items that is available in Pink

@dressesPage
Scenario: Items are not available in White after selecting Green
	Given I am on the Summer Dresses Page
	When I tick the White check box
	Then the First item from the result should not be available in White

@dressesPage
Scenario: Viewing the Yellow items on Summer Dresses Page
	Given I am on the Summer Dresses Page
	When I tick the Yellow check box
	Then the result should be showing items that is available in Yellow