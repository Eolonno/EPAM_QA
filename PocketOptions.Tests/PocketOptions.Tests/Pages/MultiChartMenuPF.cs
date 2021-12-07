using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PocketOptions.Tests.Pages
{
    public class MultiChartMenuPF : PageFactoryBase
    {
        [FindsBy(How = How.ClassName, Using = "vertical-2")]
        private IWebElement _verticalMultiChartButton;

        private readonly By _canvases = By.TagName("canvas");

        public MultiChartMenuPF(IWebDriver driver) : base(driver) { }

        public MultiChartMenuPF SelectVerticalMultiChart()
        {
            _verticalMultiChartButton.Click();

            Log.Info("Selected vertical-2 multi-chart");

            return this;
        }

        public bool IsMultiChart()
        {
            return Driver.FindElements(_canvases).Count > 1;
        }
    }
}