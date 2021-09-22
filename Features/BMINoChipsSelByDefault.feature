Feature: BMINoChipsSelByDefault
   As a website user
   I want to have more flexibility in the selection of chips
   So that the page doesn’t pre-select a chip for me and so I can easily deselect all chips


@ChipsDeselected
Scenario: Chips are deselected
	Given I navigate to BMI website
    When I scroll down to chips
    Then I check all the chips are deselected


