using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PocketOptions.Tests.Pages
{
    public class ProfileMenuPF : PageFactoryBase
    {
        [FindsBy(How = How.CssSelector, Using = "ul > li:nth-child(2) > a")]
        private IWebElement _profileSubButton;

        public ProfileMenuPF(IWebDriver driver) : base(driver) { }

        public ProfileSettingsPF GoToProfileSettings()
        {
            _profileSubButton.Click();

            Log.Info("Clicked on profile subButton");

            return new ProfileSettingsPF(Driver);
        }
    }
}