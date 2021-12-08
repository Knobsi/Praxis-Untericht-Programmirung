// Autor : Leon Gießelmann
using System;

namespace Aufgabe_5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, summe = 1;
            Console.Write("Fakultät von n: ");
            n = Convert.ToInt32(Console.ReadLine());


            while ( n > 1)
            {
                summe *= n;
                Console.WriteLine(summe);
                n--;
            }

            Console.WriteLine(summe);
        }
    }
}
