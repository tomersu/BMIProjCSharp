Feature: CloseTheVisualizer
	As the website manager
    I want to link to the Visualiser from any page within the BMI website
    So that visitors to the website can access and use this tool


@CloseVisualizerOriginalPage
Scenario: To check Visualizer closes and goes back to original page
	Given I have opened the Visualiser
    When I click the close X
    Then close the modal and the originating page from AC2 is still there.
