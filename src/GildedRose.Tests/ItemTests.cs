using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class ItemTests
    {
        [Fact]
        public void ToString_Should_Return_Correct_Content()
        {
            var item = new Item
            {
                Name = "+5 Dexterity Vest",
                SellIn = 50,
                Quality = 100
            };

            Assert.Equal("+5 Dexterity Vest, 50, 100", item.ToString());
        }

        [Fact]
        public void Should_Decrease_Quality_And_Sellin_When_Pass_A_Day()
        {
            var item = new Item("test", 10, 20);
            item.PassOneDay();
            Assert.Equal(19, item.Quality);
            Assert.Equal(9, item.SellIn);
        }

        [Fact]
        public void Quality_Should_Degrade_Twice_When_Expired()
        {
            var item = new Item("test", 0, 20);
            item.PassOneDay();
            Assert.Equal(18, item.Quality);
            item.PassOneDay();
            Assert.Equal(16, item.Quality);
        }

        [Fact]
        public void Should_Decrease_Quality_When_Update()
        {
            var item = new Item("test", 6, 20);

            item.UpdateQuality();
            Assert.Equal(19, item.Quality);
        }

        [Fact]
        public void Quality_Should_Not_Be_Negative()
        {
            var item = new Item("test", 6, 0);

            item.UpdateQuality();
            Assert.Equal(0, item.Quality);
        }
    }
}
