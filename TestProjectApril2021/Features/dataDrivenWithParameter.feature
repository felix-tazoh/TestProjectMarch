Feature: dataDrivenWithParameter
	Simple calculator for adding two numbers

@mytag
Scenario: Data Driven With Parameter
	Given I navigate to "http://angularjs.realworld.io/#/"
	And I click on sign up button
	And I enter username "felixtt267"
	And I enter Email "demo267@gmail.com"
	And I enter password "PasswordSecure"
	When I click on Sign up
	Then I should be able to sign up successfully