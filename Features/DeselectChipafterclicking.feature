Feature:DeselectChipafterclick
As a website user
I want to have more flexibility in the selection of chips
So that the page doesn’t pre-select a chip for me and so I can easily deselect all chips


@Deselectchipafterclicking

Scenario: Deselect chips after selecting
   Given I navigate to BMI website
   When I scroll down to chips
   Then I click on chips
   Then I check chips get deselected