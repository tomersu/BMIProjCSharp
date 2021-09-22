using System;
using TechTalk.SpecFlow;
using BMIProjectCsharp.Page;
using BMIProjectCsharp.Hooks;

namespace BMIProjectCsharp.Steps
{
    [Binding]
    [Scope(Tag = "OpentheVisualizer")]
    public class OpenTheVisualizerSteps:HooksSetUp
    {
        OpenTheVisualizerZoomInOutpage Zoom;
        [Given(@"I am on a BMI page that has been configured to display the Visualiser")]
        public void GivenIAmOnABMIPageThatHasBeenConfiguredToDisplayTheVisualiser()
        {
            Zoom = new OpenTheVisualizerZoomInOutpage(driver);
            Zoom.navigatetoBMI();
            
        }
        
        [When(@"I select the Visualiser")]
        public void WhenISelectTheVisualiser()
        {
            Zoom.ScrolltochipsElement();
          
            Zoom.ClickonVisualizer();
            
            
        }
        
        [Then(@"the Visualiser is displayed, including applying any variables defined in the link \(e\.g\. the product, colour, etc\.\), as shown in the UI Design for desktop and mobile")]
        public void ThenTheVisualiserIsDisplayedIncludingApplyingAnyVariablesDefinedInTheLinkE_G_TheProductColourEtc_AsShownInTheUIDesignForDesktopAndMobile()
        {
            Zoom.ZoomInZoomOutImage();
        }
        
        [Then(@"I am able to interact with the Visualiser")]
        public void ThenIAmAbleToInteractWithTheVisualiser()
        {
            
        }
        
        [Then(@"I can Zoom in and out Visualiser")]
        public void ThenICanZoomInAndOutVisualiser()
        {
            
        }
        
        [Then(@"I can view the share this link on top of the modal to other systems like facebook etc")]
        public void ThenICanViewTheShareThisLinkOnTopOfTheModalToOtherSystemsLikeFacebookEtc()
        {
            
        }
        
        [Then(@"Click on product link takes me to product lister page")]
        public void ThenClickOnProductLinkTakesMeToProductListerPage()
        {
            
        }
        
        [Then(@"I can view the house mode with different tiles and farge")]
        public void ThenICanViewTheHouseModeWithDifferentTilesAndFarge()
        {
           
        }
    }
}
