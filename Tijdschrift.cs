using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Klassen_en_Events.Tijdschrift;

namespace Klassen_en_Events
{
    internal class Tijdschrift : Boek
    {
        public Verschijningsperiode Periode { get; set; }

        public enum Verschijningsperiode
        {
            Dagelijks,
            Wekelijks,
            Maandelijks
        }

    public Tijdschrift(string isbn, string naam, string uitgever, double prijs, Verschijningsperiode periode)
        : base(isbn, naam, uitgever, prijs)
    {

        Periode = periode;
    }
        public override string ToString()
        {
            return base.ToString() + "Verschijningsperiode: " + Periode;
        }
    }
}

