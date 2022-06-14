using System;

namespace Praxis_53_KlasseKarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karte N7 = new Karte(Farbe.Kreuz, Kartenwert.N7);
            Karte N9 = new Karte(Farbe.Herz, Kartenwert.N9);

            Karte b = new Karte(Farbe.Kreuz,Kartenwert.B);

            N9.VergleicheMit(N7, Spielvariante.Kreuzspiel);//kleiner
            N9.VergleicheMit(N9, Spielvariante.Kreuzspiel);//gleich
            N7.VergleicheMit(N9, Spielvariante.Kreuzspiel);//größer

            if (b.IstTrumpf(Spielvariante.Herzspiel)) 
            {
                Console.WriteLine("Diese karte ist ein trumpf");
            }
        }
    }
}
