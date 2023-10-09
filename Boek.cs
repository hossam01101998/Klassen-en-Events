using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen_en_Events
{
    internal class Boek
    {
        public string Isbn { get; set; }
        public string Naam { get; set; }
        public string Uitgever { get; set; }
        public double Prijs {  get; set; }

        public Boek (string isbn, string naam,  string uitgever, double prijs)
        {
            
            if(prijs > 5 && prijs < 50) 
            {

                Isbn = isbn;
                Naam = naam;
                Uitgever = uitgever;
                Prijs = prijs;
                Console.WriteLine("Toegevoegd!");
            }

            else {
                Console.WriteLine("De prijs moet tussen 5 en 50e zijn.");
            }
        }

        public override string ToString()
        {
            return $"Naam: {Naam} ,Isbn: {Isbn} , Uitgever: {Uitgever} , Prijs: {Prijs}e ";
        }

        public void Lees()
        {
            Console.WriteLine("Jij bent het boek " + Naam + " aan het lezen.");
        }

    }
}
