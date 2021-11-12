// Autor : Leon.Gießelmann
using System;

namespace Aufgabe_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben sie eine zahl ein die geprüft werden soll");
            int zahl = Convert.ToInt32(Console.ReadLine());

            bool gearade = zahl % 2 == 0;
            bool kleinerAls10 = zahl < 10;
            bool groesserAls1000 = zahl > 1000;
            bool ungleich100 = zahl != 100;

            Console.WriteLine(gearade);
            Console.WriteLine(kleinerAls10);
            Console.WriteLine(groesserAls1000);
            Console.WriteLine(ungleich100);
        }
    }
}
