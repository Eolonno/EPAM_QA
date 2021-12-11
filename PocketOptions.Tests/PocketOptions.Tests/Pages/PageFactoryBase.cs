using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PocketOptions.Tests.Pages
{
    public class PageFactoryBase
    {
        protected IWebDriver Driver;

        protected PageFactoryBase(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}