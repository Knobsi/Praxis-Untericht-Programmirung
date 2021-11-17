// Autor : Leon.Gießelmann
using System;

namespace Aufgabe_2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geben sie die Länge ein ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben sie die Breite ein ");
            double b = Convert.ToInt32(Console.ReadLine());

            double c = Math.Sqrt( Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine($"LOL ICH IDIOT {c:F}");



        }
    }
}
