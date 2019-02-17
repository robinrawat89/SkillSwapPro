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
	Given User clicked on the 'Languages' tab under Profile page
	And  User click on Add New button for 'Languages'
	When User is able to add a new entry for Language with values <Language> and <Language Level>
	Then that <Language> language should be added to user profile

Examples:
		| Language | Language Level |
		| French   | Basic          |


Scenario Outline: 7 Check if user could able to add skills into profile
	Given User clicked on the 'Skills' tab under Profile page
	And  User click on Add New button for 'Skills'
	When User add a new skill <Skill> and <Skill Level>
	Then that <Skill> skill should be added to user profile

Examples:
		| Skill | Skill Level  |
		| C#    | Intermediate |