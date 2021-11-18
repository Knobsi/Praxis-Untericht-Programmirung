using System;

namespace Praxis_12_Bedingte_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double summe;
            double zwischenspeicher;

            Console.Write("Zahl 1 Bittö :");
            double zahl1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("zahl2 bittö :");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            

            if(zahl1 < zahl2)
            {
                summe = zahl1 / zahl2;

                Console.WriteLine("Deine zahl 1 war" + zahl1);
                Console.WriteLine("Deine zahl 2 war" + zahl2);
                Console.WriteLine($"Das ergebnis aus {zahl1} durch { zahl2} lautet {summe:F} ");
            }
            else
            {
                zwischenspeicher = zahl1;
                zahl1 = zahl2;
                zahl2 = zwischenspeicher;


                summe = zahl1 / zahl2;

                Console.WriteLine("Deine zahl 1 war" + zahl1);
                Console.WriteLine("Deine zahl 2 war" + zahl2);
                Console.WriteLine($"Das ergebnis aus {zahl1} durch { zahl2} lautet {summe:F}");
            }


            

        }
    }
}
