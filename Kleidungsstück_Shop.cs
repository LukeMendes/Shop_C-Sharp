using System;

namespace ConsoleApp1.Projects
{
    public class Kleidungsstück_Shop : ShopArtikel
    {
        private string farbe;
        private string jahreszeit;
        private bool änderungsmöglichkeitsFlag;

        public Kleidungsstück_Shop() : base()
        {
            farbe = "";
            jahreszeit = "";
            änderungsmöglichkeitsFlag = false;
        }

        public Kleidungsstück_Shop(string farbe, string jahreszeit, bool änderung, int artikelnummer, string bezeichnung, int besand, double preis) : base (artikelnummer,  bezeichnung, besand, preis)
        {
            this.farbe = farbe;
            this.jahreszeit = jahreszeit;
            this.änderungsmöglichkeitsFlag = änderung;
        }

        #pragma warning disable CS0108
        public void AusgabeAttribute()
        {
            Console.WriteLine("Artikelnummer: " + artikelnummer);
            Console.WriteLine("Bezeichnung: " + bezeichnung);
            Console.WriteLine("Bestand: " + bestand);
            Console.WriteLine("Preis: " + preis);
            Console.WriteLine("Farbe: " + farbe);
            Console.WriteLine("Jahreszeit: " + jahreszeit);
            Console.WriteLine("ÄnderungsmöglichkeitsFlag: " + änderungsmöglichkeitsFlag);
        }
    }
}
