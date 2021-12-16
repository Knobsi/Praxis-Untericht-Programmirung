using System;
//Berechnung der Summe der Zahl 1 bis 100
namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summe = 0;
            int i = 1;
            do
            {
                summe = summe + i;
                i++;
            }
                while (i <= 100);
            Console.WriteLine(summe);
        }
    }
}
