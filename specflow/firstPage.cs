using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace specflow
{
    class FirstPage : BasePage
    {

        public FirstPage(IWebDriver driver): base(driver)
        {
           PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement searchBar { get; set; }


        [FindsBy(How = How.CssSelector, Using = "[data-hveid='CAQQAQ'] .LC20lb")]
        public IWebElement trainlineLink { get; set; }


        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement TitleID3 { get; set; }


        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement TitleID4 { get; set; }

        public void goTo()
        {
            driver.Navigate().GoToUrl("https:www.google.co.uk");
        }

        public void searchForTrainline()
        {
            enterText(searchBar, "trainline");
            pressEnter();  
        }

        public void clickOnSite()
        {
            waitAndClick(trainlineLink);
        }


    }
}
