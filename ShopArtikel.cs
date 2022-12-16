using System;

namespace ConsoleApp1.Projects
{
    public class ShopArtikel
    {
        protected int artikelnummer = 0;
        protected string bezeichnung = "";
        protected int bestand = 0;
        protected double preis = 0;

        public ShopArtikel()
        {

        }

        public ShopArtikel(int artikelnummer, string bezeichnung, int bestand, double preis)
        {
            this.artikelnummer = artikelnummer;
            this.bezeichnung = bezeichnung;
            this.bestand = bestand;
            this.preis = preis;
        }

        public void AusgabeAttribute()
        {
            Console.WriteLine("Artikelnummer: " + artikelnummer);
            Console.WriteLine("Bezeichnung: " + bezeichnung);
            Console.WriteLine("Bestand: " + bestand);
            Console.WriteLine("Preis: " + preis);
        }

        public void BestandVerringern(int anzahl)
        {
            if(anzahl > bestand)
            {
                Console.WriteLine("Nicht mehr genügend Ware (Artikel: " + bezeichnung + ")!");
            } else {
                bestand -= anzahl;
            }
        }
    }
}
