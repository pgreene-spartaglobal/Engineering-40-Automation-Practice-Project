Feature: FilterProductByCategories
	In order to select the items I want
	As a user
	I want to be able to filter the result by different categories

@filterCategories
Scenario: Viewing all the tops items
	Given I am on the Women Page
	When I tick the Tops check box
	Then the result should be showing the Tops items

@filterCategories
Scenario: Dresses items are remained in the list after filtering
	Given I am on the Women Page
	When I tick the Tops check box
	Then the result should be showing the Dresses Items
