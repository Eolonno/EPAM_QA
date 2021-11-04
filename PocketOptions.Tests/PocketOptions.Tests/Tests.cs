using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace PocketOptions.Tests
{
    public class Tests
    {
        public static string GetRandomString(int length)
        {
            Random random = new Random();
            const string chars = "qwertyuiopasdfghjkzxcvbnm";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        [Fact]
        public void PocketOptions_ChangingUserName()
        {
            var expectedName = GetRandomString(8);
            var driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://pocketoption.com/ru/cabinet/demo-quick-high-low/");

            driver.FindElement(By.CssSelector(".social-btn--gp")).Click();
            driver.FindElement(By.CssSelector("#identifierId")).SendKeys("seleniumPocketOptionTest");
            driver.FindElement(By.CssSelector("#identifierNext > div > button")).Click();
            driver.FindElement(By.CssSelector("input[name='password']")).SendKeys("GQZ-dED-6ZQ-vUk");
            driver.FindElement(By.CssSelector("#passwordNext > div > button")).Click();
            driver.FindElement(By.CssSelector("a[href='#sub-menu-profile-modal']")).Click();
            driver.FindElement(By.CssSelector("ul > li:nth-child(2) > a")).Click();

            var nameTitle = driver.FindElement(By.CssSelector("a[data-name='nickname']"));
            nameTitle.Click();
            
            var nameInput = driver.FindElement(By.CssSelector("div.editable-input > input"));
            nameInput.Clear();
            nameInput.SendKeys(expectedName);

            driver.FindElement(By.CssSelector(".btn-sm.editable-submit")).Click();

            var expectedPopup = driver.FindElement(By.CssSelector(".gritter-without-image"));
            var name = nameTitle.Text;

            Assert.Equal(expectedName, name);
            Assert.True(expectedPopup != null);

            driver.Quit();
        }
    }
}
