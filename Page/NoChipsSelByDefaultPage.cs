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
    public class NoChipsSelByDefaultPage
    {
        IWebDriver driver;
       
        public NoChipsSelByDefaultPage(IWebDriver browser)
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
        string classcontains1primary = "MuiButtonBase-root MuiChip-root Chip-module__Chip--lKEh9 MuiChip-colorPrimary MuiChip-clickableColorPrimary MuiChip-clickable";

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

        public void CheckchipsdeFlatttakslected()
        {
            //Thread.Sleep(3000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            IWebElement Flattak = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(text(),'Flatt tak')]")));
            //Flattak.Click();
            Thread.Sleep(3000);
            //string classcontains1primary = "MuiButtonBase-root MuiChip-root Chip-module__Chip--lKEh9 MuiChip-colorPrimary MuiChip-clickableColorPrimary MuiChip-clickable";
            //string classcontains = driver.FindElement(By.XPath("//span[contains(text(),'Flatt tak')]/parent::div")).GetAttribute("class");
            Convert.ToString(classcontains1primary).Equals(Flatttakclass.GetAttribute("class")).Should().BeFalse();
        }
        public void CheckchipsdeTakproffslected()
        {
            //Thread.Sleep(3000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            IWebElement Takproff = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(text(),'Takproff')]")));
           // Takproff.Click();
            Thread.Sleep(3000);
           // string classcontains1primary = "MuiButtonBase-root MuiChip-root Chip-module__Chip--lKEh9 MuiChip-colorPrimary MuiChip-clickableColorPrimary MuiChip-clickable";
           // string classcontains = driver.FindElement(By.XPath("//span[contains(text(),'Takproff')]/parent::div")).GetAttribute("class");
            Convert.ToString(classcontains1primary).Equals(Takproffclass.GetAttribute("class")).Should().BeFalse();
        }
        public void CheckchipsdeReferansehistorieslected()
        {
            //Thread.Sleep(3000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            IWebElement Referansehistorie = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(text(),'Referansehistorie')][@class='MuiChip-label']")));
            //Referansehistorie.Click();
            Thread.Sleep(3000);
            //string classcontains1primary = "MuiButtonBase-root MuiChip-root Chip-module__Chip--lKEh9 MuiChip-colorPrimary MuiChip-clickableColorPrimary MuiChip-clickable";
           // string classcontains = driver.FindElement(By.XPath("//span[contains(text(),'Referansehistorie')][@class='MuiChip-label']/parent::div")).GetAttribute("class");
            Convert.ToString(classcontains1primary).Equals(Referansehistorieclass.GetAttribute("class")).Should().BeFalse();
        }
        public void CheckchipsdeSkratakslected()
        {
            //Thread.Sleep(3000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            IWebElement Skratak = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(text(),'Skråtak')][@class='MuiChip-label']")));
           // Skratak.Click();
            Thread.Sleep(3000);
            //string classcontains1primary = "MuiButtonBase-root MuiChip-root Chip-module__Chip--lKEh9 MuiChip-colorPrimary MuiChip-clickableColorPrimary MuiChip-clickable";
            //string classcontains = driver.FindElement(By.XPath("//span[contains(text(),'Skråtak')][@class='MuiChip-label']/parent::div")).GetAttribute("class");
            Convert.ToString(classcontains1primary).Equals(Skratakclass.GetAttribute("class")).Should().BeFalse();
        }

    }
}
