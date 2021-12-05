using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PocketOptions.Tests.Pages
{
    public class PocketOptionMainPF : PageFactoryBase
    {
        [FindsBy(How = How.CssSelector, Using = "a[href='#sub-menu-profile-modal']")]
        private IWebElement _profileButton;

        [FindsBy(How = How.XPath, Using = "//div[4]/nav/ul[1]/li[4]/a")]
        private IWebElement _expressOrderButton;

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

            Log.Info("Clicked on express order menu button");

            return new ExpressOrderMenuPF(Driver);
        }
    }
}