using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PocketOptions.Tests.Pages
{
    // TODO: split this class
    public class PocketOptionMainPF : PageFactoryBase
    {
        [FindsBy(How = How.CssSelector, Using = "a[href='#sub-menu-profile-modal']")]
        private IWebElement _profileButton;

        [FindsBy(How = How.XPath, Using = "//div[4]/nav/ul[1]/li[4]/a")]
        private IWebElement _expressOrderButton;

        [FindsBy(How = How.XPath, Using = "//div[4]/nav/ul[1]/li[6]/a")]
        private IWebElement _pendingTradeButton;

        [FindsBy(How = How.CssSelector, Using = "div.control__value.value.value--several-items > div > input")]
        private IWebElement _amountOfBetInput;

        [FindsBy(How = How.ClassName, Using = "btn-call")]
        private IWebElement _acceptBetButton;

        [FindsBy(How = How.ClassName, Using = "pair-number-wrap")]
        private IWebElement _selectedAssetButton;

        [FindsBy(How = How.CssSelector, Using = "div.items > a:nth-child(1)")]
        private IWebElement _chartTypeButton;

        [FindsBy(How = How.CssSelector, Using = "div.items > a:nth-child(5)")]
        private IWebElement _mutiChartButton;

        [FindsBy(How = How.CssSelector, Using = "div.items > a:nth-child(3)")]
        private IWebElement _drawingsButton;

        private readonly By _openedBets = By.ClassName("deals-list__item");

        public PocketOptionMainPF(IWebDriver driver) : base(driver) { }

        public ProfileMenuPF ClickToProfileMenuButton()
        {
            _profileButton.Click();

            Log.Info("Clicked on profile menu button");

            return new ProfileMenuPF(Driver);
        }

        public ExpressOrderMenuPF OpenExpressOrderMenu()
        {
            _expressOrderButton.Click();

            Log.Info("Clicked on express order button");

            return new ExpressOrderMenuPF(Driver);
        }

        public PendingTradePF OpenPendingTradeMenu()
        {
            _pendingTradeButton.Click();

            Log.Info("Clicked on pending trade button");

            return new PendingTradePF(Driver);
        }

        public PocketOptionMainPF EnterAmountOfBet(int amountOfBet)
        {
            _amountOfBetInput.Clear();
            _amountOfBetInput.SendKeys(amountOfBet.ToString());

            Log.Info($"Entered amount of the bet: {amountOfBet}");

            return this;
        }

        public PocketOptionMainPF CreateBet()
        {
            _acceptBetButton.Click();

            Log.Info("Bet created");

            return this;
        }

        public ReadOnlyCollection<IWebElement> GetOpenedBets()
        {
            return Driver.FindElements(_openedBets);
        }

        public AssetsPF OpenAssets()
        {
            _selectedAssetButton.Click();

            Log.Info("Click on assets menu button");

            return new AssetsPF(Driver);
        }

        public ChartTypeMenuPF OpenChartTypeMenu()
        {
            _chartTypeButton.Click();

            Log.Info("Chart type menu opened");

            return new ChartTypeMenuPF(Driver);
        }

        public MultiChartMenuPF OpenMulChartMenu()
        {
            _mutiChartButton.Click();

            Log.Info("Multi-chart menu opened");

            return new MultiChartMenuPF(Driver);
        }

        public DrawingsMenuPF OpenDrawingsMenu()
        {
            _drawingsButton.Click();

            Log.Info("Drawings menu opened");

            return new DrawingsMenuPF(Driver);
        }
    }
}