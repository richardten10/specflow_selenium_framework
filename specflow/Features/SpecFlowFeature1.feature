Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SmokeTest
Scenario: Navigate to website from google 
	Given I am on google
	And I search for the website
	When I click on the result
	Then the page title will be correct 
