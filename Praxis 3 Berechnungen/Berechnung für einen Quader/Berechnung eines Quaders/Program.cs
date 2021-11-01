using System;

namespace Berechnung_eines_Quaders
{
    class Program
    {
        static void Main(string[] args)
        {
            // Eingabe  breite,länge,höhe

            Console.Write("Länge ? :");
            string eingabe = Console.ReadLine();
            int Länge = Convert.ToInt32(eingabe);

            Console.Write("Breite ? :");
            int Breite = Convert.ToInt32(Console.ReadLine());


            Console.Write("Höhe ? :");
            int Höhe = Convert.ToInt32(Console.ReadLine());


            //Verarbeitung
            int grundfläche = Breite * Länge;
            int Volumen = grundfläche * Höhe;


            // Ausgabe

            Console.WriteLine("Grundfläche ist = " + grundfläche);

            Console.WriteLine("Volumen ist = " + Volumen);

        }
    }
}
