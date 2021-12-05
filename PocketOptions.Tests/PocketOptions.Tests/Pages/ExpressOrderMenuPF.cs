using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PocketOptions.Tests.Pages
{
    public class ExpressOrderMenuPF : PageFactoryBase
    {
        [FindsBy(How = How.Id, Using = "amount")]
        private IWebElement _amountOfBetInput;

        private readonly By _selectAssetButtons = By.ClassName("asset-item__call");
        private readonly By _submitButton = By.CssSelector(".button-wrapper>button");
        private readonly By _expressOrders = By.ClassName("express-item");

        public ExpressOrderMenuPF(IWebDriver driver) : base(driver) { }

        public ExpressOrderMenuPF PutOnTheFirstAssets(int NumberOfBets)
        {
            var selectAssetButtons = Driver.FindElements(_selectAssetButtons);
            for (int i = 0; i < NumberOfBets; i++)
                selectAssetButtons[i].Click();

            Log.Info("Assets selected");

            return this;
        }

        public ExpressOrderMenuPF InputAmountOfBet(float betAmount)
        {
            _amountOfBetInput.Clear();
            _amountOfBetInput.SendKeys(betAmount.ToString());

            Log.Info("Amount of bet inserted");

            return this;
        }

        public ExpressOrderMenuPF AcceptExpressOrder()
        {
            Driver.FindElement(_submitButton).Click();

            Log.Info("Express order accepted");

            return this;
        }

        public IReadOnlyCollection<IWebElement> GetExpressOrders()
        {
            return Driver.FindElements(_expressOrders);
        }

    }
}