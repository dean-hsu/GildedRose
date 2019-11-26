
namespace GildedRose.Console
{
    public class ConjuredItem : Item
    {
        public ConjuredItem(int sellin, int quality)
        :base(Item.Conjured, sellin, quality)
        {

        }

        public override void UpdateQuality()
        {
            DecreaseQuality();
            DecreaseQuality();
        }
    }
}
