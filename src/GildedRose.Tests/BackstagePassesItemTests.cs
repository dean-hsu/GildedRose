using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class BackstagePassesItemTests
    {
        [Fact]
        public void Should_Increase_Quality_When_Sellin_Above_10()
        {
            var backStagePassesItem1 = new BackstagePassesItem(20, 10);
            var backStagePassesItem2= new BackstagePassesItem(11, 15);
            backStagePassesItem1.UpdateQuality();
            backStagePassesItem2.UpdateQuality();

            Assert.Equal(11,backStagePassesItem1.Quality);
            Assert.Equal(16, backStagePassesItem2.Quality);
        }

        [Fact]
        public void Should_Double_Increase_Quality_When_Sellin_Between_6_And_10()
        {
            var backStagePassesItem1 = new BackstagePassesItem(6, 15);
            var backStagePassesItem2 = new BackstagePassesItem(10, 20);
            backStagePassesItem1.UpdateQuality();
            backStagePassesItem2.UpdateQuality();

            Assert.Equal(17, backStagePassesItem1.Quality);
            Assert.Equal(22, backStagePassesItem2.Quality);
        }

        [Fact]
        public void Should_Triple_Increase_Quality_When_Sellin_Between_1_And_5()
        {
            var backStagePassesItem = new BackstagePassesItem(5, 15);
            backStagePassesItem.UpdateQuality();

            Assert.Equal(18, backStagePassesItem.Quality);
        }

        [Fact]
        public void Quality_Should_Be_0_When_Expired()
        {
            var backStagePassesItem = new BackstagePassesItem(0, 15);
            backStagePassesItem.PassOneDay();

            Assert.Equal(0, backStagePassesItem.Quality);
        }

        [Fact]
        public void PassOneDay_Should_Double_Increase_Quanlity_Of_Backstage_Passes_When_Getting_Close_To_Expiration()
        {
            var item = new BackstagePassesItem(11, 20);

            item.PassOneDay();
            Assert.Equal(21, item.Quality);
            item.PassOneDay();
            Assert.Equal(23, item.Quality);
        }

        [Fact]
        public void PassOneDay_Should_Triple_Increase_Quanlity_Of_Backstage_Passes_When_Getting_Close_To_Expiration()
        {
            var item = new BackstagePassesItem(6, 20);

            item.PassOneDay();
            Assert.Equal(22, item.Quality);
            item.PassOneDay();
            Assert.Equal(25, item.Quality);
        }
    }
}
