using PocketOptions.Tests.Utils;
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

        [FindsBy(How = How.ClassName, Using = "pair-number-wrap")]
        private IWebElement _selectedAssetButton;

        [FindsBy(How = How.CssSelector, Using = "div.items > a:nth-child(1)")]
        private IWebElement _chartTypeMenuButton;

        [FindsBy(How = How.CssSelector, Using = "div.items > a:nth-child(5)")]
        private IWebElement _multiChartMenuButton;

        [FindsBy(How = How.CssSelector, Using = "div.items > a:nth-child(3)")]
        private IWebElement _drawingsMenuButton;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"chat-block-trigger\"]/a")]
        private IWebElement _chatMenuButton;

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

        public AssetsPF OpenAssets()
        {
            _selectedAssetButton.Click();

            Log.Info("Click on assets menu button");

            return new AssetsPF(Driver);
        }

        public ChartTypeMenuPF OpenChartTypeMenu()
        {
            _chartTypeMenuButton.Click();

            Log.Info("Chart type menu opened");

            return new ChartTypeMenuPF(Driver);
        }

        public MultiChartMenuPF OpenMulChartMenu()
        {
            _multiChartMenuButton.Click();

            Log.Info("Multi-chart menu opened");

            return new MultiChartMenuPF(Driver);
        }

        public DrawingsMenuPF OpenDrawingsMenu()
        {
            _drawingsMenuButton.Click();

            Log.Info("Drawings menu opened");

            return new DrawingsMenuPF(Driver);
        }

        public ChatMenuPF OpenChatMenu()
        {
            _chatMenuButton.Click();

            Log.Info("Chat menu opened");

            return new ChatMenuPF(Driver);
        }
    }
}