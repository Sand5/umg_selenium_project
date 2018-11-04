Feature: SignUp
	In order to use the conduit website
	As a new user
	I want to be able to signup for an account


Scenario: Create a new account
Given I am not logged in
When I complete the sign up form
Then I am logged in
And my username is displayed

