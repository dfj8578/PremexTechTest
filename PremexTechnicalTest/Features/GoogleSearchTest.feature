Feature: GoogleSearchTest
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@E2ETest
Scenario: Verify the Search Function for Cars in London
	Given I navigate to the page "www.google.com"
	Then I Type in the Search Text box 'Cars in London'
	And I click on Search Button
	And validate how many Gumtree links there are available
	Then Navigate to each Gumtree link
	And Confirm the title is displayed
	
	

	
	
   
	