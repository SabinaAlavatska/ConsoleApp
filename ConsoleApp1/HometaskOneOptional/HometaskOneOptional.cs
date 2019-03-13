using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace ConsoleApp1
{
    [TestFixture]
    public class HometaskOneOptional
    {
        ChromeDriver chromeDriver = new ChromeDriver();
        string url = "http://fortune.com/40-under-40/";

        [SetUp]
        public void SetUp ()
        {
            chromeDriver.Manage().Timeouts().ImplicitWait = new TimeSpan(0,0,0,2);
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl(url);
        }

        [Test]
        public void GoToUrl ()
        {
            StartPage pageObject = new StartPage(chromeDriver);
            string expectedText = pageObject.firstArticleHeader.Text;
            pageObject.firstArticleLink.Click();
            string actualText = pageObject.clickedArticleHeader.Text;
            bool isContainsString = actualText.Contains(expectedText);
            Assert.IsTrue(isContainsString, "Selected article name does not match with opened article page title");
        }

        [TearDown]
        public void Clear ()
        {
            chromeDriver.Quit();
        }
    }
}
