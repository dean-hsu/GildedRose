namespace GildedRose.Console
{
    public class Item
    {
        protected const string AgedBrie = "Aged Brie";
        protected const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        protected const string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";
        protected const string Conjured = "Conjured Mana Cake";

        public Item()
        {

        }

        public Item(string name, int sellin, int quality)
        {
            Name = name;
            SellIn = sellin;
            Quality = quality;
        }

        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public override string ToString()
        {
            return $"{Name}, {SellIn}, {Quality}";
        }

        public virtual void PassOneDay()
        {
            UpdateQuality();

            if (IsExpired())
            {
                UpdateQuality();
            }
            DecreaseSellinDays();
        }

        public virtual void UpdateQuality()
        {
            DecreaseQuality();
        }

        private bool IsQualityPositive()
        {
            return Quality > 0;
        }

        protected void IncreaseQuality()
        {
            if (IsQualityUnderLimit())
            {
                Quality += 1;
            }
        }

        protected void DecreaseQuality()
        {
            if (IsQualityPositive()) Quality = Quality - 1;
        }

        protected bool IsExpired()
        {
            return SellIn <= 0;
        }

        public virtual void DecreaseSellinDays()
        {
            SellIn -= 1;
        }

        protected bool IsQualityUnderLimit()
        {
            return Quality < 50;
        }
    }
}