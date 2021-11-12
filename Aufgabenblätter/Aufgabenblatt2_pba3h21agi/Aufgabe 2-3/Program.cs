// Autor : Leon.Gießelmann
using System;

namespace Aufgabe_2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geben sie die erste Länge ein ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben sie die Breite ein ");
            int b = Convert.ToInt32(Console.ReadLine());

            double Rechnungsausgabe = Math.Sqrt( Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine(Rechnungsausgabe);



        }
    }
}
