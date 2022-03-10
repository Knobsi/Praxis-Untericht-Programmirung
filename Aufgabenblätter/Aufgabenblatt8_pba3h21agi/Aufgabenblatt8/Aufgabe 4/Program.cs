//Autor : Leon Gießelmann
using System;

namespace Aufgabe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Jahr ? :");
            int jahr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Monat ? :");
            int monat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tag ? :");
            int tag = Convert.ToInt32(Console.ReadLine());


            if (monat == 1)
            {
                monat = 13;
                jahr = jahr - 1;
            }
            else if (monat == 2)
            {
                monat = 14;
                jahr = jahr - 1;
            }


            int jahrhundert = jahr / 100;
            jahr = jahr % 100;
            int w = (tag + (26 * (monat + 1)) / 10 + (5 * jahr) / 4 + jahrhundert / 4 + 5 * jahrhundert - 1) % 7;

            switch(w)
            {
                case 0:
                    Console.WriteLine("Montag");
                    break;
                case 1:
                    Console.WriteLine("Dienstag");
                    break;
                case 2:
                    Console.WriteLine("Mitwoch");
                    break;
                case 3:
                    Console.WriteLine("Donnerstag");
                    break;
                case 4:
                    Console.WriteLine("Freitag");
                    break;
                case 5:
                    Console.WriteLine("Samstag");
                    break;
                case 6:
                    Console.WriteLine("Sontag");
                    break;
            }

        }
    }
}
