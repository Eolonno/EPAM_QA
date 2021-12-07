using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PocketOptions.Tests.Pages
{
    public class PendingTradePF : PageFactoryBase
    {
        [FindsBy(How = How.CssSelector, Using = "button[data-id='field-symbol']")]
        private IWebElement _assetsButton;

        [FindsBy(How = How.Name, Using = "open_time")]
        private IWebElement _openTimeInput;

        [FindsBy(How = How.Name, Using = "amount")]
        private IWebElement _amountOfBet;

        [FindsBy(How = How.XPath, Using = "//form/div[4]/div[2]/a")]
        private IWebElement _placeBetButton;

        private readonly By _assets = By.ClassName("opt");
        private readonly By _popup = By.ClassName("gritter-without-image");
        private readonly By _activePendingBetsCounter = By.XPath("//a[3]/*/span");

        public PendingTradePF(IWebDriver driver) : base(driver) { }

        public PendingTradePF SelectRandomAsset()
        {
            _assetsButton.Click();
            var assets = Driver.FindElements(_assets);
            var randomAssetIndex = new Random().Next(0, assets.Count);
            assets[randomAssetIndex].Click();

            Log.Info($"Selected {randomAssetIndex} asset");

            return this;
        }

        public PendingTradePF EnterOpenTime(int numberOfSeconds)
        {
            _openTimeInput.Clear();

            var timeToEnter = DateTime.Now.AddSeconds(numberOfSeconds).ToString("yyyy'-'MM'-'dd HH:mm:ss");

            _openTimeInput.SendKeys(timeToEnter);

            Log.Info($"Entered time: {timeToEnter}");

            return this;
        }

        public PendingTradePF EnterAmountOfBet(double amount)
        {
            _amountOfBet.Clear();
            _amountOfBet.SendKeys(amount.ToString());

            Log.Info($"Entered amount of bet: {amount}");

            return this;
        }

        public PendingTradePF PlaceBet()
        {
            _placeBetButton.Click();

            Log.Info("Bet placed");

            return this;
        }

        public (IWebElement popup, IWebElement counter) GetPopupAndCounter()
        {
            var popup = Driver.FindElement(_popup);
            var activePendingBetsCounter = Driver.FindElement(_activePendingBetsCounter);

            return (popup, activePendingBetsCounter);
        }
    }
}