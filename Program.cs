using Klassen_en_Events;
using static Klassen_en_Events.Tijdschrift;

class Program
{


    static void Main()
    {
        Boek boek1 = new Boek("1111111", "Titanic", "James", 6.25);
        Boek boek2 = new Boek("2222222", "How to be a good guy", "Maarten", 15.75);
        Boek boek3 = new Boek("3333333", "Barbie", "Peter", 7.75);
        //dit boek kost minder dan 5€. Normal gezien gaan wij niet kunnen maken dit boek
        Boek boek4 = new Boek("4444444", "Need for Speed", "Inma", 3.75);
        //
        Boek boek5 = new Boek("5555555", "Best hacker", "Frank", 11.75);

        Console.WriteLine(boek1.ToString());


        Tijdschrift tijdschrift1 = new Tijdschrift("AAAAAAAA", "National Geographic", "Discovery Max", 9.95, Verschijningsperiode.Maandelijks);
        Tijdschrift tijdschrift2 = new Tijdschrift("BBBBBBBB", "Wild Frank", "Discovery Max", 17.15, Verschijningsperiode.Maandelijks);
        //Deze kost ook minder dan 5€
        Tijdschrift tijdschrift3 = new Tijdschrift("CCCCCCCC", "The latest trends", "Kobe", 3.95, Verschijningsperiode.Maandelijks);
        //
        Tijdschrift tijdschrift4 = new Tijdschrift("DDDDDDDD", "Cristiano Ronaldo", "Mario", 19.05, Verschijningsperiode.Maandelijks);
        Tijdschrift tijdschrift5 = new Tijdschrift("EEEEEEEE", "Best dogs", "Claudie", 7.50, Verschijningsperiode.Maandelijks);

        Console.WriteLine();
        Console.WriteLine("******************************************");
        Console.WriteLine();

        Bestelling<Boek> bestelling1 = new Bestelling<Boek>(boek1, DateTime.Now, 3);
        Bestelling<Boek> bestelling2 = new Bestelling<Boek>(boek2, DateTime.Now, 2);
        Bestelling<Boek> bestelling3 = new Bestelling<Boek>(boek4, DateTime.Now, 7);

        Bestelling<Tijdschrift> bestelling4 = new Bestelling<Tijdschrift>(tijdschrift1, DateTime.Now, 1);
        Bestelling<Tijdschrift> bestelling5 = new Bestelling<Tijdschrift>(tijdschrift2, DateTime.Now, 3);
        Bestelling<Tijdschrift> bestelling6 = new Bestelling<Tijdschrift>(tijdschrift3, DateTime.Now, 2);

        Console.WriteLine(bestelling1.ToString());
        Console.WriteLine(bestelling2.ToString());
        /* Console.WriteLine(bestelling3.ToString());
        Console.WriteLine(bestelling4.ToString());
        Console.WriteLine(bestelling5.ToString());
        Console.WriteLine(bestelling6.ToString()); */

        Console.WriteLine();
        Console.WriteLine("******************************************");
        Console.WriteLine();

        bestelling1.BestellingBevestigd += (sender, e) => Console.WriteLine(e);
        bestelling2.BestellingBevestigd += (sender, e) => Console.WriteLine(e);
        bestelling3.BestellingBevestigd += (sender, e) => Console.WriteLine(e);
        bestelling4.BestellingBevestigd += (sender, e) => Console.WriteLine(e);
        bestelling5.BestellingBevestigd += (sender, e) => Console.WriteLine(e);
        bestelling6.BestellingBevestigd += (sender, e) => Console.WriteLine(e);


        Tuple<string, int, double> bestellingInfo = bestelling1.Bestel();
        Tuple<string, int, double> bestellingInfo2 = bestelling2.Bestel();
        //bestelling 3 gaat niet werken want boek 4 bestaat niet (Dat boek kost minder dan 5e)
        Tuple<string, int, double> bestellingInfo3 = bestelling3.Bestel();
        Tuple<string, int, double> bestellingInfo4 = bestelling4.Bestel();
        Tuple<string, int, double> bestellingInfo5 = bestelling5.Bestel();
        Tuple<string, int, double> bestellingInfo6 = bestelling6.Bestel();









    }

}

