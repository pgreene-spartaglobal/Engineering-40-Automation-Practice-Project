Feature: Navigation
As a user
I want to be able to navigate through different pages
Using the navigation bar

Scenario: Women Tab
	Given I am on the home page
	When I press the Women button
	Then I should see the Women page

Scenario: Dresses tab
	Given I am on the home page
	When I press the Dresses button
	Then I should see the Dresses page

Scenario: T-Shirts tab
	Given I am on the home page
	When I press T-Shirts button
	Then I should see the T-Shirts page