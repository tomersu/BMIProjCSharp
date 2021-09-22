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
    public class ClosetheVisualizerpage
    {
        IWebDriver driver;

        public ClosetheVisualizerpage(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }
        string BMIUrl = "https://www.bmigroup.com/no/beregning-og-visualisering/";
        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Visualiseringsprogram')]")]
        public IWebElement ScrolltoElement;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Prøv vårt visualiseringsverktøy')]")]
        public IWebElement Visualizer;

        [FindsBy(How = How.CssSelector, Using = ".MuiButtonBase-root.MuiIconButton-root.jss120.jss126.jss122.ContainerDialog-module__iconButton--1-0Fm")]
        public IWebElement CrossLink;
        [FindsBy(How = How.Id, Using = "onetrust-accept-btn-handler")]
        public IWebElement CookieButton;
        public void navigatetoBMI()
        {
            driver.Navigate().GoToUrl(BMIUrl);
            driver.Manage().Cookies.DeleteAllCookies();
           
            CookieButton.Click();

        }
        public void ScrolltochipsElement()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();", ScrolltoElement);//Scroll to the element
            Thread.Sleep(5000);
            Visualizer.Click();
        }
        public void CLickonCrossandcheck()
        {
            String mainWindowHandle = driver.WindowHandles.Last();
            var newWindow=driver.SwitchTo().Window(mainWindowHandle);
            CrossLink.Click();
            string currenturl=newWindow.Url;
           currenturl.Contains("https://www.bmigroup.com/no/beregning-og-visualisering/").Should().BeTrue();

            /*Set<String> allWindowHandles = driver.getWindowHandles();
             Iterator<String> iterator = allWindowHandles.iterator();

             // Here we will check if child window has other child windows and will fetch the heading of the child window
             while (iterator.hasNext())
             {
                 String ChildWindow = iterator.next();
                 if (!mainWindowHandle.equalsIgnoreCase(ChildWindow))
                 {
                     driver.switchTo().window(ChildWindow);
                     WebElement text = driver.findElement(By.id("sampleHeading"));
                     System.out.println("Heading of child window is " + text.getText());
                     String WindowHandle = driver.GetWindowHandle();*/


        }

        
    }
}
