using System;

namespace ConsoleApp1.Projects
{
    public class TestShop
    {
        public static void Main(String[] args)
        {
            Elektrogerät_Shop Panasonic = new Elektrogerät_Shop(12, true, 63828, "SmartTV", 100, 599.90);

            Kleidungsstück_Shop Nike = new Kleidungsstück_Shop("Schwarz", "Sommer", false, 74298, "Laufschuhe", 2000, 29.99);

            Panasonic.AusgabeAttribute();
            Console.WriteLine();
            Panasonic.AusgabeAttribute();

            Console.WriteLine();

            Nike.BestandVerringern(200);
            Nike.BestandVerringern(300);

            Console.WriteLine();

            Nike.AusgabeAttribute();
            Console.WriteLine();
            Nike.AusgabeAttribute();
        }
    }
}
