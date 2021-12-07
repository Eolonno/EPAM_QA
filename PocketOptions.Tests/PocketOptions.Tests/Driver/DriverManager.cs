using System.Collections.Generic;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PocketOptions.Tests.Driver
{
    public static class DriverSingleton
    {
        private static List<string> _profiles = new()
        {
            "Profile 1",
            "Profile 4",
        };

        private static IWebDriver _driver;
        public static IWebDriver GetWebDriver()
        {
            if (_driver == null)
            {
                var options = new ChromeOptions();
                options.AddArguments(@"user-data-dir=C:\Users\yegor\AppData\Local\Google\Chrome\User Data\");
                options.AddArguments(@"profile-directory=Profile 1");
                _driver = new ChromeDriver(Directory.GetCurrentDirectory(), options);
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