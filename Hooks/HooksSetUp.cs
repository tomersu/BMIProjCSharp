using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BMIProjectCsharp.Hooks
{
    
    public class HooksSetUp
    {
        public IWebDriver driver;
        [BeforeScenario]
        public void Setup()
        {
           driver= new ChromeDriver();
           driver.Manage().Window.Maximize();

        }
        [AfterScenario]
        public void Teardown()
        {
            driver.Close();
            driver.Quit();

        }
    }
}
