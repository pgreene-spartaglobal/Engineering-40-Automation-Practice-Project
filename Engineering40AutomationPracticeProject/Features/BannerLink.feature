Feature: BannerLink
	As a user, I want to be sent to appropriate page when I click on the banner.

@mytag
Scenario: Get to saving page
	Given I am on the home pages
	When I click on the banner
	Then I should not be on the same page
