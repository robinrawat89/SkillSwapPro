Feature: User ShareSkill Details
	In order to share skills 
	As a skill trader
	I want to add the details of my skills that I know

Background: 
Given User is using "Chrome" browser
When  User navigate to "http://www.skillswap.pro/" url
And   User enter valid credentials "utest5896@gmail.com" and "test@1234"
Then  User is able to Login


		

Scenario Outline: 1 Check whether user could able to add Share skill into profile
	Given User clicked on the 'Share Skill' button
	When User enter the details <Title>, <Description>,<Category>,<Subcategory>,<Tags>,<Service Type>,<Location Type>, <Skill Trade>, <Skill Exchange> , <Work Samples> , <Active>
	And  User enter the Available days
	Then that <Title> skill should be added to user Manage Listing page

	Examples:
		| Title       | Description | Category          | Subcategory          | Tags       | Service Type    | Location Type | Skill Trade | Skill Exchange | Work Samples | Active |
		| Skill share | Basic       | Video & Animation | Lyric & Music Videos | testSkills | One-off service | On-site       | Credit      | Availiable     |              | Active |