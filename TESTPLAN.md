# Automation Practice Shopping Website Test Plan
## Table of Contents
* [Introduction](#introduction)
* [Approach](#approach)
* [Plan](#plan)
* [Features to be Tested](#features-to-be-tested)
* [Features Not to be Tested](#features-not-to-be-tested)
* [Pass/Fail Criteria](#passfail-criteria)
* [Defect Management](#defect-management)
## Introduction
### Test Objectives
The test of the shopping website should validate the requirements to ensure that the website works according to user requirements and business needs so that the user can:
* Browse the website
* Make purchases
* Manage their account
Once testing has concluded a higher level of confidence will be achieved that the system will work according to user requirements and meet business needs.
### Scope of Testing
The scope of testing will include browsing, purchasing and account management.

The testing will not include verification of valid emails, newsletter subscription service and customer service contact. Non functional requirements will not be tested.

### System Overview
## Approach
### Assumptions
User requirements were assumed by the test team as they were not provided for this project.
### Constraints
* Three days may not be enough time to test the entire website
* Access to the website source code is not available
### Coverage
Test coverage will be measured by the number of requirements tested.
### Test tools
* SpecFlow
* Selenium
* NUnit
### Test Type
Functional testing will be performed on testable requirements
### Test Data
Test data will be created specifically for the tests by the test team.
## Plan
### Roles
| Name | Title | Responsibilities |
| ------------- |-------------| -----|
| Adeboye Azeez | Tester | Design and execute test cases for browsing |
| Seng Fai Chan | Tester | Design and execute test cases for browsing |
| Eduard Pavliuc | Tester | Design and execute test cases for browsing |
| Samoondeeswari Sheela | Tester | Design and execute test cases for browsing |
| Rasik Rana | Tester | Design and execute test cases for browsing |
| Brandon Stephens | Tester | Design and execute test cases for purchasing |
| Cosmin Balosache | Tester | Design and execute test cases for purchasing |
| Nazir Ahmed | Tester | Design and execute test cases for purchasing |
| Dipak Mukesh | Tester | Design and execute test cases for purchasing |
| Norberta Balaisyte | Tester | Design and execute test cases for purchasing |
| Philip Greene | Test Manager | Lead all testing activities, including test planning, test execution and status reporting. Design and execute test cases for account management |
| Ciaran Cullen | Tester | Design and execute test cases for account management |
| Jez Horton | Tester | Design and execute test cases for account management |
| Canute Gilzene | Tester | Design and execute test cases for account management |
### Major Tasks
Day 1: 
*	Create Test Plan
*	Generate user stories
*	Write scenarios in Gherkin syntax

Day 2:
*	Finish writing scenarios in Gherkin syntax
*	Generate step files from features
*	Write implementation for step files
*	Execute test cases

Day 3:
*	Finish executing test cases
*	Test summary report
*	Create slide deck 
*	Organise speaking roles for presentation 
### Test Environment
#### Hardware
All testing will be performed using HP Notebooks
(14) HP 250 G6 Notebook
Specifications:
Intel Core i5-7200U
8GB DDR4 RAM
#### Software
Visual Studio 2019
## Features to be Tested
### Browsing
* Navigation
* Filtering items
* Search for items
* Sorting items
* Viewing items (quick/full view)
* View special offers
* Social media links
* Add item to Wishlist
* Compare items
* View information
* view customer service info
### Purchasing
* Add to cart (colour, size)
* View cart summary
* Checkout
* Remove from cart
* Set quantity
* Sign in/ Register before purchase
* Set delivery address
* Set shipping information
* Set payment options
### Account
* Create account
* View account
* View orders
* View credit slips
* View account addresses
* View personal information
* Login to account
## Features Not to be Tested
* Newsletter subscription
* Customer service contact
* Email validation
## Pass/Fail Criteria
For the system to pass the test the following criteria must be met:
* All financial calculations are correct
* All website navigation functions work correctly
* Customer account functions work correctly
* Customer purchase functions work correctly
## Defect Management
| Severity | Description |
|---|---|
| 1 - Critical | Objectives or completion of test case are impacted |
| 2 - High | Defects which prove to be detrimental to the system |
| 3 - Medium | Defects which provide invalid/incorrect information |
| 4 - Low | Aesthetic defects such as misplaced button |
| 5 - Info | An item observed during testing that may require further information |

