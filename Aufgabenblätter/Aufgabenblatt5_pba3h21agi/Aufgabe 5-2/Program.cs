// Autor : Leon Gießelmann
using System;

namespace Aufgabe_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie eine zahl ein die von 1 bis zu der zahl als quadratzahl ausgegeben werden soll");
            int zahl = Convert.ToInt32(Console.ReadLine());
            int zähler = 1;
            double ergebnis;
            double summe=0;

            while( zähler <= zahl)
            {
                ergebnis = Math.Pow(2, zähler);
                Console.WriteLine($" {zähler}² =  {ergebnis}");
                summe = summe + ergebnis;
                zähler++;
                Console.WriteLine(summe);
            }
            
            
        }
    }
}
