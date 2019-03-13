using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace ConsoleApp1
{
    class PageObject
    {
        public PageObject (ChromeDriver chromeDriver)
        {
            PageFactory.InitElements(chromeDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@data-article-id]")]
        public IWebElement firstArticleLink { get; set; }

        [FindsBy(How = How.ClassName, Using = "fullname")]
        public IWebElement firstArticleHeader { get; set; }

        [FindsBy(How = How.ClassName, Using = "franchise-person-name")]
        public IWebElement clickedArticleHeader { get; set; }
    }
}
