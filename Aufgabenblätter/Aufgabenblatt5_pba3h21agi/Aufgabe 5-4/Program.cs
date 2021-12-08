using System;

namespace Aufgabe_5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bestellung stückzahl : ");
            int stuckZahl = Convert.ToInt32(Console.ReadLine());



            int restStuck = stuckZahl % 500;
            int stuck = stuckZahl / 500;

            Console.WriteLine($"{stuck} Einheit(en) zu 500 stück,");
          
            stuck = restStuck / 200;
            restStuck = restStuck % 200;

            Console.WriteLine($"{stuck} Einheit(en) zu 200 stück,");

            stuck = restStuck / 50;
            restStuck = restStuck % 50;          

            Console.WriteLine($"{stuck} Einheit(en) zu 50 stück,");

            stuck = restStuck / 20;
            restStuck = restStuck % 20;

            Console.WriteLine($"{stuck} Einheit(en) zu 20 stück,");
            Console.WriteLine($"Die Lieferung der restlichen {restStuck} Einzelposten ist nicht möglich");

        }
    }
}
