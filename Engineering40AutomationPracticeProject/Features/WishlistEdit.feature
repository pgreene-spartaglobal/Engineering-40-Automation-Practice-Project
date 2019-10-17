Feature: WishlistEdit
	in order to login into my account
	as a user
	i want to see my wishlist and edit it

Scenario: Create new wishlist
	Given I have logged in correctly
	And i have pressed the wishlist button
	And i have given my wishlist a name
	And i pressed the save wishlist button
	Then i should see the new wishlist

Scenario: check date on new wishlist
	Given I have logged in correctly
	And i have pressed the wishlist button
	And i have given my wishlist a name
	And i pressed the save wishlist button
	Then i should see the correct date

Scenario: check add to wishlist
	Given I have logged in correctly
	And i have pressed the wishlist button
	And i have given my wishlist a name
	And i pressed the save wishlist button
	And i have pressed on a item
	And i have added it to a wishlist
	And i go back to the wishlist page
	And i click on view
	Then i should see the item i added

Scenario: check delete works with new wishlist
	Given I have logged in correctly
	And i have pressed the wishlist button
	And i have given my wishlist a name
	And i pressed the save wishlist button
	And i delete the new wishlist
	Then i should not be able to see the wishlist

	