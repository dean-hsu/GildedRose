
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class AgedBrieItemTests
    {
        [Fact]
        public void Should_Increase_Quality_When_Quanlity_Under_50_And_Not_Expired()
        {
            var agedBrieItem = new AgedBrieItem(10, 20);
            agedBrieItem.UpdateQuality();

            Assert.Equal(21, agedBrieItem.Quality);
        }

        [Fact]
        public void Should_Increase_Quality_When_Expired()
        {
            var agedBrieItem = new AgedBrieItem(0, 20);
            agedBrieItem.UpdateQuality();

            Assert.Equal(21, agedBrieItem.Quality);
        }
    }
}
