using System.Collections.Generic;

namespace GildedRose.Console
{
    public class GildedRose
    {
        public GildedRose(IList<Item> items)
        {
            Items = items;
        }

        public IList<Item> Items { get; }

        public void PassOneDay()
        {
            foreach (var item in Items)
            {
                item.PassOneDay();
            }
        }
    }
}
