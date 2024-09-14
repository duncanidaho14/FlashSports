using FlashSports.Controllers;
using Xunit;

namespace TestFlashSport
{
    public class FlashSportsUnitTest
    {
        #region Public methods
        [Fact]
        public void ShouldReturnListOfSports()
        {
            // ARRANGE
            var controller = new FlashSportsController();

            // ACT
            var result = controller.GetSports();

            // ASSERT
            Assert.NotNull(result);
            Assert.True(result.());
        }
        #endregion
    }
}