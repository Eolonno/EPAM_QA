using System;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PocketOptions.Tests.Pages
{
    public class ChatMenuPF : PageFactoryBase
    {
        [FindsBy(How = How.XPath, Using = "//div[1]/div[3]/a[@class=\"chat_link\"]")]
        private IWebElement _generalChatButton;

        [FindsBy(How = How.TagName, Using = "textarea")]
        private IWebElement _messageTextarea;

        [FindsBy(How = How.XPath, Using = "//div[@class=\"chat_message_form_button\"]/a")]
        private IWebElement _sendMessageButton;

        private readonly By _ErrorPopup = By.ClassName("chat_popup_error");

        public ChatMenuPF(IWebDriver driver) : base(driver) { }

        public ChatMenuPF OpenGeneralChat()
        {
            _generalChatButton.Click();

            Log.Info("Common chat is opened");

            return this;
        }

        public ChatMenuPF TypeMessage(string message)
        {
            _messageTextarea.SendKeys(message);

            Log.Info($"Typed message: {message}");

            return this;
        }

        public ChatMenuPF SendMessage()
        {
            _sendMessageButton.Click();

            Log.Info("Message sent");

            return this;
        }

        public IWebElement GetErrorPopup()
        {
            return Driver.FindElement(_ErrorPopup);
        }

    }
}