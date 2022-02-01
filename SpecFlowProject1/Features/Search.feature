Feature: Search
	As a user of Rokomari.com
	I want to search for a book 
	So that I can see the book

@search
Scenario: Search for a Course
	Given I navigate to Rokomari.com
	When I click on the search field
	And I type automation in the search field 
	And I cllick the search button
	Then the result page is displayed 