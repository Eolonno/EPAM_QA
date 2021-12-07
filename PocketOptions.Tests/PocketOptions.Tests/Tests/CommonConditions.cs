using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PocketOptions.Tests.Driver;

namespace PocketOptions.Tests.Utils
{
    [SetUpFixture]
    public abstract class CommonConditions
    {
        protected IWebDriver Driver;

        [SetUp]
        public void InitBrowserAndLogin()
        {
            Driver = DriverSingleton.GetWebDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl("https://pocketoption.com/ru/cabinet/demo-quick-high-low/");
        }

        [TearDown]
        public void CloseBrowser()
        {
            DriverSingleton.CloseWebDriver();
        }
    }
}