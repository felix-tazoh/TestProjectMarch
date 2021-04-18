Feature: Registration
	In order to access the website, I will need to first register.

@mytag
Scenario: Valid Registration
	Given I navigate to website
	And I click on sign up button
	And I enter username
	And I enter Email
	And I enter password
	When I click on Sign up
	Then I should be able to sign up successfully