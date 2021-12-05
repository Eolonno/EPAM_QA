using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PocketOptions.Tests.Driver;

namespace PocketOptions.Tests.Utils
{
    [SetUpFixture]
    public abstract class CommonConditions
    {
        protected IWebDriver driver;

        [SetUp]
        public void InitBrowserAndLogin()
        {
            driver = DriverSingleton.GetWebDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://pocketoption.com/ru/cabinet/demo-quick-high-low/");
        }

        [TearDown]
        public void CloseBrowser()
        {
            DriverSingleton.CloseWebDriver();
        }
    }
}