using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace ConsoleApp1
{
    [TestFixture]
    public class HometaskOneOptional
    {
        ChromeDriver chromeDriver;
        string url = "http://fortune.com/40-under-40/";

        [SetUp]
        public void SetUp ()
        {
            chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Timeouts().ImplicitWait = new TimeSpan(0,0,0,2);
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl(url);
        }

        [Test]
        public void GoToUrl ()
        {
            StartPage pageObject = new StartPage(chromeDriver);
            pageObject.firstArticleLink.Click();
            
        }

        [TearDown]
        public void Clear ()
        {
            chromeDriver.Quit();
        }
    }
}
