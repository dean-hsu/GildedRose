

namespace GildedRose.Console
{
    public class BackstagePassesItem : Item
    {
        public BackstagePassesItem(int sellin, int quality)
            : base(Item.BackstagePasses, sellin, quality)
        {

        }

        public override void PassOneDay()
        {
            UpdateQuality();

            if (IsExpired())
            {
                Quality = 0;
            }
            DecreaseSellinDays();
        }

        public override void UpdateQuality()
        {
            IncreaseQuality();

            if (SellIn < 11)
            {
                IncreaseQuality();
            }

            if (SellIn < 6)
            {
                IncreaseQuality();
            }
        }
    }
}
