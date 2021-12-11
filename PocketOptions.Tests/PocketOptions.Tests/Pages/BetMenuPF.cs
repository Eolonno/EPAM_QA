using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using PocketOptions.Tests.Utils;

namespace PocketOptions.Tests.Pages
{
    public class BetMenuPF : PageFactoryBase
    {
        [FindsBy(How = How.CssSelector, Using = "div.control__value.value.value--several-items > div > input")]
        private IWebElement _amountOfBetInput;

        [FindsBy(How = How.ClassName, Using = "btn-call")]
        private IWebElement _callBetButton;

        [FindsBy(How = How.ClassName, Using = "btn-put")]
        private IWebElement _putBetButton;

        private readonly By _openedBets = By.ClassName("deals-list__item");

        public BetMenuPF(IWebDriver driver) : base(driver) { }

        public BetMenuPF EnterAmountOfBet(int amountOfBet)
        {
            _amountOfBetInput.Clear();
            _amountOfBetInput.SendKeys(amountOfBet.ToString());

            Log.Info($"Entered amount of the bet: {amountOfBet}");

            return this;
        }

        public BetMenuPF CreateCallBet()
        {
            _callBetButton.Click();

            Log.Info("Call bet created");

            return this;
        }

        public BetMenuPF CreatePutBet()
        {
            _putBetButton.Click();

            Log.Info("Put bet created");

            return this;
        }

        public ReadOnlyCollection<IWebElement> GetOpenedBets()
        {
            Thread.Sleep(200);
            return Driver.FindElements(_openedBets);
        }
    }
}