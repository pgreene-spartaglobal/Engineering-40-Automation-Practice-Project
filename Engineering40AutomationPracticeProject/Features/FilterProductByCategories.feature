Feature: FilterProductByCategories
	In order to select the items I want
	As a user
	I want to be able to filter the result by different categories

@filterCategories
Scenario: Viewing all the Tops items
	Given I am on the Women Page
	When I tick the Tops check box
	Then the result should be showing the Tops items

@filterCategories
Scenario: Dresses items are remained in the list after selecting Tops
	Given I am on the Women Page
	When I tick the Tops check box
	Then the result should be showing the Dresses items

@filterCategories
Scenario: Summer Dresses items are remained in the list after selecting Evening Dresses
	Given I am on the Dresses Page
	When I tick the Evening Dresses check box
	Then the result should be showing the Summer Dresses items

@filterCategories
Scenario: Viewing all the Summer Dresses
	Given I am on the Dresses Page
	When I tick the Summer Dresses check box
	Then the result should be showing the Summer Dresses items