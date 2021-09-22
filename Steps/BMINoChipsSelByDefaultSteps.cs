using BMIProjectCsharp.Hooks;
using BMIProjectCsharp.Page;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BMIProjectCsharp.Steps
{
    [Binding]
    [Scope(Tag="ChipsDeselected")]
    public class BMINoChipsSelByDefaultSteps : HooksSetUp
    {   NoChipsSelByDefaultPage chippage;
        [Given(@"I navigate to BMI website")]
        public void GivenINavigateToBMIWebsite()
        {        
            chippage = new NoChipsSelByDefaultPage(driver);
            chippage.navigatetoBMI();
            
        }
        
        [When(@"I scroll down to chips")]
        public void WhenIScrollDownToChips()
        {
            chippage.ScrolltochipsElement();
        }
        
        [Then(@"I check all the chips are deselected")]
        public void ThenICheckAllTheChipsAreDeselected()
        {
            chippage.CheckchipsdeFlatttakslected();
            chippage.CheckchipsdeTakproffslected();
            chippage.CheckchipsdeReferansehistorieslected();
            chippage.CheckchipsdeSkratakslected();

        }
    }
}
