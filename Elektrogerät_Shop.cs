using System;

namespace ConsoleApp1.Projects
{
    public class Elektrogerät_Shop : ShopArtikel
    {
        private int garantiezeit;
        private bool angebotDesMonatsFlag;

        public Elektrogerät_Shop() : base()
        {
            garantiezeit = 24;
            angebotDesMonatsFlag = false;
        }

        public Elektrogerät_Shop(int garantie, bool angebot, int artikelnummer, string bezeichnung, int bestand, double preis) : base(artikelnummer, bezeichnung, bestand, preis)
        {
            garantiezeit = garantie;
            angebotDesMonatsFlag = angebot;
        }

        #pragma warning disable CS0108
        public void AusgabeAttribute()
        {
            Console.WriteLine("Artikelnummer: " + artikelnummer);
            Console.WriteLine("Bezeichnung: " + bezeichnung);
            Console.WriteLine("Bestand: " + bestand);
            Console.WriteLine("Preis: " + preis);
            Console.WriteLine("Garantiezeit: " + garantiezeit);
            Console.WriteLine("DngebotDesMonatsFlag: " + angebotDesMonatsFlag);
        }
    }
}
