Feature: SpecFlowFeature1
	In order to check for a property 
	As a Property Owner
	I want to search the property by name

@mytag
Scenario Outline: Search A Proeprty With Valid Name
	Given I clicked on the Your Properties page
	When I search for a property by its <Name>
	Then I property should appear in the search list
	
	Examples: 
	| Name   |
	| Saniya |