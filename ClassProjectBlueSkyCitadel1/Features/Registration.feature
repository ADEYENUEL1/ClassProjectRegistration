Feature: Registration
	In order to use the site
	I need to register

@mytag
Scenario: Valid Registration
	Given I navigate to the site
	When  I click on register link
	And   I enter firstname
	And   I enter lastname
	And   I enter email "emailaddress"
	And   I enter mobile number
	And   I enter password
	And   I enter confirm password
	And   I click on Signup
	Then  I should be registered
