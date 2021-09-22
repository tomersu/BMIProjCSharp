using BMIProjectCsharp.Hooks;
using BMIProjectCsharp.Page;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BMIProjectCsharp.Steps
{
    [Binding]
    [Scope(Tag = "Deselectchipafterclicking")]
    public class DeselectChipafterclickSteps : HooksSetUp
    {
       BMIDeselectAllChipsPage deslectchippage;
        [Given(@"I navigate to BMI website")]
        public void GivenINavigateToBMIWebsite()
        {
            deslectchippage = new BMIDeselectAllChipsPage(driver);
            deslectchippage.navigatetoBMI();

        }
        
        [When(@"I scroll down to chips")]
        public void WhenIScrollDownToChips()
        {
            deslectchippage.ScrolltochipsElement();
            
        }
        
        [Then(@"I click on chips")]
        public void ThenIClickOnChips()
        {
            deslectchippage.Checkdeslectchipsdisable();      
        }
        
        [Then(@"I check chips get deselected")]
        public void ThenICheckChipsGetDeselected()
        {
            deslectchippage.checkdeslecteafterclick();
        }
    }
}
