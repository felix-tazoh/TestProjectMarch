Feature: DataDrivenWithExample
	Simple calculator for adding two numbers

@mytag
Scenario Outline: Data Driven With Example
	Given I navigate to "http://angularjs.realworld.io/#/"
	And I click on sign up button
	And the user enter Username "<Username>"
	And the user enter Email "<Email>"
	And the user enter password "<Password>"
	When I click on Sign up
	Then I should be able to sign up successfully

	Examples:
	| Username    | Email                 | Password       |
	| FefeConsult | fefeconsult@tempo.com | PasswordSecure |
	| Solanche    | Solanche@sol.com      | PasswordSecure |
	| Felixtt77   | felixtt@tempo.com     | PasswordSecure |