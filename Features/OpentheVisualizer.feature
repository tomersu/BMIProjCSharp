Feature: Open the Visualizer
  As the website manager
  I want to link to the Visualiser from any page within the BMI website
  So that visitors to the website can access and use this tool


@OpentheVisualizer
Scenario: Open the Visualizer with Zoomin and Zoom out
	Given I am on a BMI page that has been configured to display the Visualiser
    When I select the Visualiser
    Then the Visualiser is displayed, including applying any variables defined in the link (e.g. the product, colour, etc.), as shown in the UI Design for desktop and mobile
    And I am able to interact with the Visualiser
    And I can Zoom in and out Visualiser
    And I can view the share this link on top of the modal to other systems like facebook etc
    And Click on product link takes me to product lister page 
    And I can view the house mode with different tiles and farge
