Feature: User Profile Details
	In order to update my profile 
	As a skill trader
	I want to add the details that I know

Background: 
Given User is using "Chrome" browser
When  User navigate to "http://www.skillswap.pro/" url
And   User enter valid credentials "utest5896@gmail.com" and "test@1234"
Then  User is able to Login


Scenario Outline: 6 Check if user could able to add languages into profile
	Given User clicked on the 'Skills' tab under Profile page
	And  User click on Add New button
	When User is able to add a new entry for Language with values <Language> and <Language Level>
	Then that language should be displayed on user profile listings

Examples:
		| Language | Language Level |
		| French   | Basic          |