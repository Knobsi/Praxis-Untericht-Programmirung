//Autor : Leon Gießelmann
using System;

namespace Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ergebnis = Fakultaet(5);
            Console.Write(ergebnis);
        }
        
        public static double Fakultaet(int zahl)
        {
            double ergebnis = 1;

            for(int i = 1; i <= zahl; i++)
            {
                ergebnis *= i;
            }

            return ergebnis;
        }
        
    }
}
