// Autor : Leon Gießelmann
using System;

namespace Aufgabe_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie eine zahl ein sie bis auf 0 runter zählen soll");
            int zahl = Convert.ToInt32(Console.ReadLine());

            while(zahl >= 0)
            {
                Console.WriteLine(zahl);
                zahl--;
            }
        }
    }
}
