using BMIProjectCsharp.Hooks;
using Bogus.DataSets;
using FluentAssertions;
using Google.Protobuf.WellKnownTypes;
using java.awt;
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
using java.util;
using List = java.util.List;
//using List = NUnit.Framework.List;

namespace BMIProjectCsharp.Page
{
    public class OpenTheVisualizerZoomInOutpage
    {
        IWebDriver driver;

        public OpenTheVisualizerZoomInOutpage(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }
        string BMIUrl = "https://www.bmigroup.com/no/beregning-og-visualisering/";
        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Visualiseringsprogram')]")]
        public IWebElement ScrolltoElement;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Prøv vårt visualiseringsverktøy')]")]
        public IWebElement Visualizer;


        [FindsBy(How = How.Id, Using = "onetrust-accept-btn-handler")]
        public IWebElement CookieButton;

        String zoomInJs;

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
            Thread.Sleep(5000);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();", ScrolltoElement);//Scroll to the element
            Thread.Sleep(5000);
        }

        public void ClickonVisualizer()
        {
            Visualizer.Click();
        }
        
        public void ZoomInZoomOutImage()
        {
           // IWebElement shadowRootElement = (IWebElement)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].shadowRoot", attachedWebElement);

            Thread.Sleep(4000);
           // driver.SwitchTo().Frame(1);
            //Thread.Sleep(4000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
           // IWebElement roofimage=(IWebElement)js.ExecuteScript('document.querySelector("body > img")');
            zoomInJs = "document.body.style.zoom='1.5'";
            js.ExecuteScript(zoomInJs);
            Thread.Sleep(5000);     
            zoomInJs = "document.body.style.zoom='0.5'";
            js.ExecuteScript(zoomInJs);
            Thread.Sleep(5000);
            zoomInJs = "document.body.style.zoom='1'";
            js.ExecuteScript(zoomInJs);
            Thread.Sleep(10000);
        }
    }
}
