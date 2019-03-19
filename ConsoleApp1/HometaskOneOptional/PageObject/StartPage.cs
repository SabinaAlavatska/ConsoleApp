﻿using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace ConsoleApp1
{
    class StartPage
    {
        public StartPage (ChromeDriver chromeDriver)
        {
            PageFactory.InitElements(chromeDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[1]")]
        public IWebElement firstArticleLink { get; set; }

    }
}