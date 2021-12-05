using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PocketOptions.Tests.Pages
{
    public class ProfileSettingsPF : PageFactoryBase
    {
        [FindsBy(How = How.CssSelector, Using = "a[data-name='nickname']")]
        private IWebElement _nicknameField;

        [FindsBy(How = How.CssSelector, Using = "div.editable-input > input")]
        private IWebElement _nickNameInput;

        [FindsBy(How = How.CssSelector, Using = ".btn-sm.editable-submit")]
        private IWebElement _submitNewNicknameButton;

        private By _successPopup = By.ClassName("gritter-without-image");

        public ProfileSettingsPF(IWebDriver driver) : base(driver)
        { }

        public ProfileSettingsPF ChangeNickName(string newName)
        {
            _nicknameField.Click();
            _nickNameInput.Clear();
            _nickNameInput.SendKeys(newName);
            _submitNewNicknameButton.Click();

            Log.Info("Nickname changed");

            return this;
        }

        public (IWebElement Popup, IWebElement NicknameField) GetPopupAndNewNickname()
        {
            var popup = Driver.FindElement(_successPopup);
            return (popup, _nicknameField);
        }
    }
}
