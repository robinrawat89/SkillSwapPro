Feature: User Profile Details
	In order to update my profile 
	As a skill trader
	I want to add the details that I know

Background: 
Given User is using "Chrome" browser
When  User navigate to "http://www.skillswap.pro/" url
And   User enter valid credentials "utest5896@gmail.com" and "test@1234"
Then  User is able to Login


Scenario: 1 Check if user could able to add Description for the profile
	Given User clicked on the Edit icon for Description field
	And  User clicked on the Description box
	When User enter text for description
	Then User is able to view descritpion for the profile

	
Scenario Outline: 2 Check if user could able to edit the name for the profile
	Given User clicked on the User Naem on Profile page
	When User edit <FirstName> and <LastName>
	And  User click Save button
	Then name is updated for the User profile


Examples:
		| FirstName     | LastName     |
		| TestFirstName | TestLastName |
		
		

Scenario: 3 Check if user could able to add Availability for the profile
	Given  User clicked on the edit icon for availability
	When User click the dropdown icon for availability
	And User select the "Full Time" option
	Then User is able to select the  availability for the profile


Scenario: 4 Check if user could able to add hours for the profile
	Given  User clicked on the edit icon for Hours
	When User click the dropdown icon for Hours
	And User select the "Less than 30hours a week" option
	Then User is able to select the hours for the profile


Scenario: 5 Check if user could able to add Earn target for the profile
	Given  User clicked on the edit icon for Earn target
	When User click the dropdown icon for Earn target
	And User select the "Less than $500 per month" option for Earn target
	Then User is able to select the Earn target for the profile


Scenario Outline: 6 Check whether user could able to add languages into profile
	Given User clicked on the 'Languages' tab under Profile page
	And  User click on Add New button for 'Languages'
	When User is able to add a new entry for Language with values <Language> and <Language Level>
	Then that <Language> language should be added to user profile

Examples:
		| Language | Language Level |
		| French   | Basic          |


Scenario Outline: 7 Check whether user could able to add skills into profile
	Given User clicked on the 'Skills' tab under Profile page
	And  User click on Add New button for 'Skills'
	When User add a new skill <Skill> and <Skill Level>
	Then that <Skill> skill should be added to user profile

Examples:
		| Skill | Skill Level  |
		| C#    | Intermediate |


Scenario Outline: 8 Check whether user could able to add education into profile
	Given User clicked on the 'Education' tab under Profile page
	And  User click on Add New button for 'Education'
	When User add a Education <College>, <Country>,<Title>,<Degree> and <Year of Graduation>
	Then that <College>,<Country> education should be added to user profile

	Examples:
		| College                        | Country     | Title | Degree | Year of Graduation |
		| Unitec Institute of Technology | Afghanistan | B.A   | Honors | 2018               |


Scenario Outline: 9 Check if user could able to add Certification into profile
	Given User clicked on the 'Certifications' tab under Profile page
	And  User click on Add New button for 'Certifications'
	When User add a new <Certificate>, <From> and <Year>
	Then that <Certificate> certificate should be added to user profile

Examples:
		| Certificate | From  | Year |
		| ISTQB       | ANZTB | 2018 |