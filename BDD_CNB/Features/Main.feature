@CNBPreferred
Feature: CNBPreferred

Scenario: Load Preferred Page
	Given a customer loads the main CNB page
	When the customer clicks the Preferred button
	Then the Preferred page loads with title 'Preferred Banking | City National Bank,Home Equity Loans | City National Bank'

