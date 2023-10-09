using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen_en_Events
{
    internal class Bestelling <T> where T : Boek
    {
        private static int _volgnummerTeller = 1;
        public int Id { get; }
        public T Item { get; set; }
        public DateTime Datum { get; set; }
        public int Aantal { get; set; }

        public event EventHandler<string> BestellingBevestigd;
        public Bestelling(T item, DateTime datum, int aantal)
        {
            Id = _volgnummerTeller++;
            Item = item;

            if (Item.Naam == null)
            {
                Console.WriteLine("Item bestaat niet!");
            }
            else
            {
                Datum = datum;
                Aantal = aantal;
                Console.WriteLine("De gegevens zijn goed ingevoerd, Je mag zij bestellen.");
            }
        }

        public override string ToString()
        {
            return $"Id: {Id}, Item : {Item}, Datum: {Datum}, Aantal: {Aantal} ";
            
        }

        public Tuple<string, int, double> Bestel()
        {
            double totalePrijs = 0;

            if (Item is Boek boek && Item.Naam != null)
            {
                totalePrijs = Math.Round(boek.Prijs * Aantal,2);

                OnBestellingBevestigd($"Bestelling bevestigd: {boek.Naam} ({boek.Isbn})," +
                    $" Aantal: {Aantal}, Totale prijs: {totalePrijs}e");
            }

            return new Tuple<string, int, double>(((Boek)Item).Isbn, Aantal, totalePrijs);
        }
        protected virtual void OnBestellingBevestigd(string boodschap)
        {
            BestellingBevestigd?.Invoke(this, boodschap);
        }
    }
}
