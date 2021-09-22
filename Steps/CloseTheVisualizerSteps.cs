using BMIProjectCsharp.Hooks;
using BMIProjectCsharp.Page;
using System;
using TechTalk.SpecFlow;

namespace BMIProjectCsharp.Steps
{
    [Binding]
    [Scope(Tag = "CloseVisualizerOriginalPage")]
    public class CloseTheVisualizerSteps : HooksSetUp
    {
        ClosetheVisualizerpage close;
           [Given(@"I have opened the Visualiser")]
        public void GivenIHaveOpenedTheVisualiser()
        {
            close = new ClosetheVisualizerpage(driver);
            close.navigatetoBMI();
        }
        
        [When(@"I click the close X")]
        public void WhenIClickTheCloseX()
        {
            close.ScrolltochipsElement();
           
            
        }
        
        [Then(@"close the modal and the originating page from AC(.*) is still there\.")]
        public void ThenCloseTheModalAndTheOriginatingPageFromACIsStillThere_(int p0)
        {
            close.CLickonCrossandcheck();
        }
    }
}
