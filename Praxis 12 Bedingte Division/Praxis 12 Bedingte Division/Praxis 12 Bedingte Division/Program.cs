using System;

namespace Praxis_12_Bedingte_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarirt summe
            double summe;

            //Fragt nach 2 zahlenwärten die Dividirt werden sollen
            Console.Write("Zahl 1 Bittö :");
            double zahl1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("zahl2 bittö :");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            
            //Wen zahl 1 größer als zahl 2 ist dan wechsel zahl 1 und 2
            if(zahl1 > zahl2)
            {
                (zahl1, zahl2) = (zahl2, zahl1);
            }

            //Rechnet die summe aus
            summe = zahl1 / zahl2;

            //Gibt die eingegebenen zahlen und das ergebnis aus
            Console.WriteLine("Deine zahl 1 war" + zahl1);
            Console.WriteLine("Deine zahl 2 war" + zahl2);
            Console.WriteLine($"Das ergebnis aus {zahl1} durch { zahl2} lautet {summe:F} ");

        }
    }
}
