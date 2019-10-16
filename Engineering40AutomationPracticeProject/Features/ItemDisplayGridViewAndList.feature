Feature: ItemDisplayGridViewAndList
	I want to be able to change the 
	Item display between grid and list view

Scenario: Grid view 
	Given I am in the Category page
	When I click on the grid view option
	Then The items should be displayed in grid view

Scenario: List view
	Given I am in the Category page
	When I click on the list view option 
	Then The items should be displayed in list view

