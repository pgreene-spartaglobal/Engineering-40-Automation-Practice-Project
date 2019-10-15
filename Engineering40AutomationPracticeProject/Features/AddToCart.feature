Feature: Add to cart 
Adding to the cart from homepage

 Scenario: Add to cart from homepage
    Given I am on the home page
    And I have opted an item
    And I have chosen the colour
    And I have picked the size
    And I have added the quantity
    When I press the add to the cart button
    Then I should be able to to see the item added to the cart