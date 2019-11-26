using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class SulfurasItemTests
    {
        [Fact]
        public void Should_Never_Update_Quality()
        {
            var item = new SulfurasItem(10, 20);
            item.UpdateQuality();
            Assert.Equal(20,item.Quality);
        }

        [Fact]
        public void Should_Never_Update_Quality_When_Expired()
        {
            var item = new SulfurasItem(0, 20);
            item.UpdateQuality();;
            Assert.Equal(20, item.Quality);
        }
    }
}
