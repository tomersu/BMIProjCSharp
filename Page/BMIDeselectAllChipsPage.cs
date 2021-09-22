using BMIProjectCsharp.Hooks;
using FluentAssertions;
using Google.Protobuf.WellKnownTypes;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BMIProjectCsharp.Page
{
   public class BMIDeselectAllChipsPage
    {
        IWebDriver driver;

        public BMIDeselectAllChipsPage(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }
        string BMIUrl = "https://www.bmigroup.com/no/referansehistorier/";
        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Historier til å bli inspirert av')]")]
        public IWebElement ScrolltoElement;

        [FindsBy(How = How.ClassName, Using = "MuiChip-label")]
        public IWebElement Flatttak;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Flatt tak')]/parent::div")]
        public IWebElement Flatttakclass;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Takproff')]")]
        public IWebElement Takproff;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Takproff')]/parent::div")]
        public IWebElement Takproffclass;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Referansehistorie')][@class='MuiChip-label']")]
        public IWebElement Referansehistorie;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Referansehistorie')][@class='MuiChip-label']/parent::div")]
        public IWebElement Referansehistorieclass;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Skråtak')][@class='MuiChip-label']")]
        public IWebElement Skratak;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Skråtak')][@class='MuiChip-label']/parent::div")]
        public IWebElement Skratakclass;
       
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Fjern alle')]")]
        public IWebElement Fjernalle;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Fjern alle')]/parent::a")]
        public IWebElement Fjernalleenable;

        string FjernalleclassDisable = "MuiTypography-root MuiLink-root MuiLink-underlineHover CardCollectionSection-module__clear-all--PWh4J AnchorLink-module__Anchorlink--2h9z0 AnchorLink-module__Anchorlink--disabled--10sg5 MuiTypography-colorPrimary";

        [FindsBy(How = How.Id, Using = "onetrust-accept-btn-handler")]
        public IWebElement CookieButton;

        public void navigatetoBMI()
        {
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl(BMIUrl);
            driver.Manage().Cookies.DeleteAllCookies();
            Thread.Sleep(3000);
            CookieButton.Click();

        }
        public void ScrolltochipsElement()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();", ScrolltoElement);//Scroll to the element
            Thread.Sleep(5000);
        }

        public void Checkdeslectchipsdisable()
        {
            Thread.Sleep(3000);
            Flatttak.Click();
            Thread.Sleep(3000);
            Takproff.Click();
            Thread.Sleep(3000);
            Referansehistorie.Click();
            Thread.Sleep(3000);
            Skratakclass.Click();
            Thread.Sleep(3000);
            String FjernalleEnabled= Fjernalleenable.GetAttribute("class");
            Convert.ToString(FjernalleclassDisable).Equals(FjernalleEnabled).Should().BeFalse();
        }
        public void checkdeslecteafterclick()
        {
           Thread.Sleep(3000);          
            try
            {
                Fjernalle.Click();
            }
            catch (Exception e)
            {
               driver.FindElement(By.XPath("//*[@class='CardCollectionSection-module__group-chips--2oGb7']/a")).Click();
               
            }
            Thread.Sleep(3000);
            String FjernalleEnabled = Fjernalleenable.GetAttribute("class");
            Convert.ToString(FjernalleclassDisable).Equals(FjernalleEnabled).Should().BeTrue();
        }
       
    }
}

