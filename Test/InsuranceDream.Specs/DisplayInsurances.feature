Feature: DisplayInsurances
	In order to subscribe insurance
	As a prospect
	I want to see home insurance

#prix hors taxe - Net Price or base price 
#prix TTC - Price including tax 
#prix d'achat - purchase price 
#prix de vente - sales price

@mytag
Scenario: Show insurance
	When I open insurance page
	Then the result should show the home insurance
	And the base price is 200
	And the sales price is 240

Scenario: Show Fire Option
	When I open insurance page
	Then the result should show the home insurance
	And the Fire Option is display with empty checkbox
	And the Fire Option is 30

Scenario: Check Fire Option
	When I check fire option
	Then the result should refresh the home insurance
	And the base price is 230
	And the sales price is 276
