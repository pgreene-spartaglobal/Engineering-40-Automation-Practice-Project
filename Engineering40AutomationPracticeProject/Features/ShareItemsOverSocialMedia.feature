Feature: ShareItemsOverSocialMedia
	As a user,
	I want to be able to share items over social media


Scenario: Share on facebook
	Given I am on the Dresses Page
	And I have selected an Item
	When I click on the facebook button
	Then I should be redirected to facebook to post about my Item

Scenario: Share on twitter
	When I click on the twitter button
	Then I should be redirected to twitter to post about my Item
	
Scenario: Share on google+
	When I click on the google+ button
	Then I should be redirected to google+ to post about my Item

Scenario: Share on pinterest
	When I click on the pinterest button
	Then I should be redirected to pinterest to post about my Item

