using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class ConjuredItemTests
    {
        [Fact]
        public void Should_Decrease_Twice_When_Update()
        {
            var item = new ConjuredItem(10, 20);
            item.UpdateQuality();
            Assert.Equal(18, item.Quality);
        }

        [Fact]
        public void Should_Decrease_4_Times_When_Expired()
        {
            var item = new ConjuredItem(0, 20);
            item.PassOneDay();
            Assert.Equal(16, item.Quality);
            item.PassOneDay();
            Assert.Equal(12, item.Quality);
        }
    }
}
