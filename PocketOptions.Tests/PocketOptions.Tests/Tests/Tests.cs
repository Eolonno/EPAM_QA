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

            var nameAndPopup = new PocketOptionMainPF(driver)
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
            var expressOrders = new PocketOptionMainPF(driver)
                .OpenExpressOrderMenu()
                .PutOnTheFirstAssets(numberOfAssets)
                .InputAmountOfBet(amountOfBet)
                .AcceptExpressOrder()
                .GetExpressOrders();

            expressOrders.Should().NotBeNull();
        }
    }
}
