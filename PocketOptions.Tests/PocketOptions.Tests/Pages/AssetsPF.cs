using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace PocketOptions.Tests.Pages
{
    public class AssetsPF : PageFactoryBase
    {
        private readonly By _addToFavoriteButtons = By.ClassName("change_symbol");
        private readonly By _favoriteAssets = By.ClassName("assets-favorites-item");
        private readonly By _removeFavoriteAssetButtons = By.ClassName("assets-favorites-item__close");

        public AssetsPF(IWebDriver driver) : base(driver) { }

        public AssetsPF AddRandomAssetToFavorite()
        {
            var addToFavoriteButtons = Driver.FindElements(_addToFavoriteButtons);
            var random = new Random();
            var randomIndex = random.Next(0, addToFavoriteButtons.Count - 1);

            addToFavoriteButtons[randomIndex].Click();

            Log.Info($"Added to favorite (index): {randomIndex}");

            return this;
        }

        public IReadOnlyCollection<IWebElement> GetFavoriteAssets()
        {
            var favoriteAssets = Driver.FindElements(_favoriteAssets);

            // TODO: this place
            //RemoveFavorites();

            return favoriteAssets;
        }

        private void RemoveFavorites()
        {
            foreach (var button in Driver.FindElements(_removeFavoriteAssetButtons))
                button.Click();

            Driver.FindElement(_removeFavoriteAssetButtons).Click();

            Log.Info("Favorite assets removed");
        }
    }
}