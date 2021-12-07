using FluentAssertions;
using NUnit.Framework;
using PocketOptions.Tests.Pages;
using PocketOptions.Tests.Utils;

namespace PocketOptions.Tests
{
    [TestFixture]
    //[Parallelizable(ParallelScope.Children)]
    public class Tests : CommonConditions
    {
        [Test]
        public void PocketOption_ChangingUserName()
        {
            var newName = StringUtils.GetRandomString(8);

            var nameAndPopup = new PocketOptionMainPF(Driver)
                .ClickToProfileMenuButton()
                .GoToProfileSettings()
                .ChangeNickName(newName)
                .GetPopupAndNewNickname();

            nameAndPopup.NicknameField.Text.Should().Be(newName);
            nameAndPopup.Popup.Should().NotBeNull();
        }

        [Test]
        public void PocketOption_CreateExpressOrder()
        {
            var numberOfAssets = 3;
            var amountOfBet = 1;
            var expressOrders = new PocketOptionMainPF(Driver)
                .OpenExpressOrderMenu()
                .PutOnTheFirstAssets(numberOfAssets)
                .InputAmountOfBet(amountOfBet)
                .AcceptExpressOrder()
                .GetExpressOrders();

            expressOrders.Should().NotBeNullOrEmpty();
        }

        [Test]
        public void PocketOption_CreatePendingTrade()
        {
            var delay = 10;
            var amountOfBet = 1;

            var popupAndCounter = new PocketOptionMainPF(Driver)
                .OpenPendingTradeMenu()
                .SelectRandomAsset()
                .EnterOpenTime(delay)
                .EnterAmountOfBet(amountOfBet)
                .PlaceBet()
                .GetPopupAndCounter();

            popupAndCounter.counter.Should().NotBeNull();
            popupAndCounter.popup.Should().NotBeNull();
        }

        [Test]
        public void PocketOption_CreateBet()
        {
            var amountOfBet = 1;

            var openedBets = new PocketOptionMainPF(Driver)
                .EnterAmountOfBet(amountOfBet)
                .CreateBet()
                .GetOpenedBets();

            openedBets.Should().NotBeNullOrEmpty();
        }

        [Test]
        public void PocketOption_AddAssetToFavorite()
        {
            var favoriteAssets = new PocketOptionMainPF(Driver)
                .OpenAssets()
                .AddRandomAssetToFavorite()
                .GetFavoriteAssets();

            favoriteAssets.Should().NotBeNullOrEmpty();
        }

        [Test]
        public void PocketOption_ChangeChartTypeToLine()
        {
            var isLine = new PocketOptionMainPF(Driver)
                .OpenChartTypeMenu()
                .SelectLineChartType()
                .IsLineChartTypeActive();

            isLine.Should().BeTrue();
        }

        [Test]
        public void PocketOption_MakeMultiChart()
        {
            var isMultiChart = new PocketOptionMainPF(Driver)
                .OpenMulChartMenu()
                .SelectVerticalMultiChart()
                .IsMultiChart();

            isMultiChart.Should().BeTrue();
        }

        [Test]
        public void PocketOption_BuildFibonacciFan()
        {
            var drawingsCounter = new PocketOptionMainPF(Driver)
                .OpenDrawingsMenu()
                .BuildFibonacciFan()
                .GetDrawingsCounter();

            drawingsCounter.Should().NotBeNull();
        }


    }
}
