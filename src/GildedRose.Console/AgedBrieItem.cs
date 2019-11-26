

namespace GildedRose.Console
{
    public class AgedBrieItem : Item
    {
        public AgedBrieItem(int sellin, int quality)
        :base(Item.AgedBrie,sellin, quality)
        {

        }

        public override void UpdateQuality()
        {
            IncreaseQuality();
        }
    }
}
