using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using PocketOptions.Tests.Utils;

namespace PocketOptions.Tests.Pages
{
    public class DrawingsMenuPF : PageFactoryBase
    {
        [FindsBy(How = How.XPath, Using = "//div[1]/div/a[5]")]
        private IWebElement _fibonacciFanButton;

        [FindsBy(How = How.XPath, Using = "//a[3]/div[1]/span")]
        private IWebElement _drawingsCounter;

        public DrawingsMenuPF(IWebDriver driver) : base(driver) { }

        public DrawingsMenuPF BuildFibonacciFan()
        {
            _fibonacciFanButton.Click();

            Log.Info("Fibonacci line built");

            return this;
        }

        public IWebElement GetDrawingsCounter()
        {
            return _drawingsCounter;
        }
    }
}