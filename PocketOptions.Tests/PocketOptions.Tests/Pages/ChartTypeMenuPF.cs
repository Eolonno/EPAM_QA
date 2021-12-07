using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PocketOptions.Tests.Pages
{
    public class ChartTypeMenuPF : PageFactoryBase
    {
        [FindsBy(How = How.CssSelector, Using = "div.chart-list-block > ul > li:nth-child(1) > a")]
        private IWebElement _lineChartTypeButton;

        [FindsBy(How = How.CssSelector, Using = "div.chart-list-block > ul > li:nth-child(1)")]
        private IWebElement _lineChartTypeMainDiv;

        public ChartTypeMenuPF(IWebDriver driver) : base(driver) { }

        public ChartTypeMenuPF SelectLineChartType()
        {
            _lineChartTypeButton.Click();

            Log.Info("Line chart type selected");

            return this;
        }

        public bool IsLineChartTypeActive()
        {
            return _lineChartTypeMainDiv.GetAttribute("class").Contains("active");
        }
    }
}