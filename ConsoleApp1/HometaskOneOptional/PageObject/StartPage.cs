using OpenQA.Selenium.Chrome;
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

        [FindsBy(How = How.XPath, Using = "//*[@data-article-id]")]
        public IWebElement firstArticleLink { get; set; }

        [FindsBy(How = How.ClassName, Using = "fullname")]
        public IWebElement firstArticleHeader { get; set; }

        [FindsBy(How = How.ClassName, Using = "franchise-person-name")]
        public IWebElement clickedArticleHeader { get; set; }
    }
}
