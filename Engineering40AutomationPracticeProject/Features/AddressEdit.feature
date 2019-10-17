Feature: AddressEdit
     In order to add an address
	 As a user
	 I can view the address page then add a new address ensuring all of the 
	 fields aere correct


Scenario: Logged in Successfully
    Given I have logged in to see account
    And I am on the My Accounts Page
	Then I should See a My Accounts title
	
Scenario: Address Button Available
    Given I have logged in to see account
	And I am on the My Accounts Page
	Then I should see a My Addresses Button
	
Scenario: Navigate to My Addresses	
    Given I have logged in to see account
	And I am on the My Accounts Page
	When I press My Addresses
	Then I should be directed to the My Addresses page
	
Scenario: On Correct Addresses Page	
    Given I have logged in to see account
	And I am on the My Addresses Page
	Then I should see a My Addresses Header
	
Scenario: AddAddress Button Available	
    Given I have logged in to see account
	And I am on the My Addresses Page
	Then I should be able to see Add new Address Button
	
Scenario: Click AddAddress Button 	
    Given I have logged in to see account
	And I am on the My Addresses Page
	When I press Add new Address Button
	Then I should be directed to the Add Address page	