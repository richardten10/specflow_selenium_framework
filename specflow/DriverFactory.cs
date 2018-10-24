﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace specflow
{
    public class DriverFactory
    {
        private IWebDriver driver;

        public IWebDriver getDriver()
        {
            if (driver == null)
            {
                setDriver();
            }
            return driver;
        }
        private void setDriver()
        {
            driver = new ChromeDriver(); 
        }
    }
}
