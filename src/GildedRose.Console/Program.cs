using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("OMGHAI!");
            var items = new List<Item>
            {
                new Item("+5 Dexterity Vest", 10, 20),
                new AgedBrieItem(2, 0),
                new Item("Elixir of the Mongoose", 5, 7),
                new SulfurasItem(0, 80),
                new BackstagePassesItem(15, 20),
                new ConjuredItem(3, 6)
            };

            var gildedRose = new GildedRose(items);

            for (var i = 0; i < 31; i++)
            {
                System.Console.WriteLine("-------- day " + i + " --------");
                System.Console.WriteLine("name, sellIn, quality");
                foreach (var item in gildedRose.Items)
                {
                    System.Console.WriteLine(item);
                }
                System.Console.WriteLine("");
                gildedRose.PassOneDay();
            }
        }
    }
}
