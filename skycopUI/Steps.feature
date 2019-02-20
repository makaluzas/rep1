Feature: SkycopSteps

Scenario: Open Skycop claim page
	Given I navigate to claims
	Then i set Kaunas at departure airport
	Then 	Then i set last arrived airport to Dublin
	Then I set airlines to wizzair
	Then I select flight number 1234
	Then I select flight date
	Then I select problem 
	Then I seleckt delayed time
	Then I select when i was informed about flight cancellation
	Then I Select reason
	Then I select that i heard about them google search
	Then I describe situation
	Then i enter flight reservation number
	Then I put personal information
	Then I enter my birth date
	Then I enter my email
	Then I enter mu phone number