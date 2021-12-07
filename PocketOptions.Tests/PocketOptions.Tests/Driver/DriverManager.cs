using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PocketOptions.Tests.Driver
{
    public static class DriverSingleton
    {
        private static IWebDriver _driver;
        public static IWebDriver GetWebDriver()
        {
            if (_driver == null)
            {
                var options = new ChromeOptions();
                options.AddArguments(@"user-data-dir=c:\Users\yegor\AppData\Local\Google\Chrome\User Data\");
                _driver = new ChromeDriver(Directory.GetCurrentDirectory(), options);
                //_driver.Manage().Window.Maximize();
            }

            return _driver;
        }

        public static void CloseWebDriver()
        {
            _driver.Close();
            _driver = null;
        }
    }
}