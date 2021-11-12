// Autor :Leon.Gießelmann
using System;

namespace Aufgabe_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Addiren
            //Aufgabe Zahlen Berechnen

            //Aufforderung einer Zahl zum Addiren
            Console.WriteLine("Geben sie bitte zwei zahlen ein die sie addiren Möchten");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            //Berechnung der Zwei zahlen

            int Summe = zahl1 + zahl2;

            //Ausgabe der erechneten zahl
            Console.WriteLine($"Die zahl aus {zahl1} und {zahl2} ergibt {Summe}");
            #endregion
            #region subtrahieren

            //Aufforderung einer Zahl zum subtrahieren
            Console.WriteLine("Geben sie bitte zwei zahlen ein die sie subtrahieren Möchten");
            int zahl3 = Convert.ToInt32(Console.ReadLine());
            int zahl4 = Convert.ToInt32(Console.ReadLine());

            //Berechnung der Zwei zahlen

            int Summe1 = zahl3 - zahl4;

            //Ausgabe der erechneten zahl
            Console.WriteLine($"Die zahl  {zahl3} minus {zahl4} ergibt {Summe1}");

            #endregion
            #region multiplizieren

            //Aufforderung einer Zahl zum multiplizieren
            Console.WriteLine("Geben sie bitte zwei zahlen ein die sie multiplizieren Möchten");
            int zahl5 = Convert.ToInt32(Console.ReadLine());
            int zahl6 = Convert.ToInt32(Console.ReadLine());

            //Berechnung der Zwei zahlen

            int Summe2 = zahl5 * zahl6;

            //Ausgabe der erechneten zahl
            Console.WriteLine($"Die zahl  {zahl5} mal {zahl6} ergibt {Summe2}");

            #endregion
            #region dividieren

            //Aufforderung einer Zahl zum dividieren
            Console.WriteLine("Geben sie bitte zwei zahlen ein die sie dividieren Möchten");
            int zahl7 = Convert.ToInt32(Console.ReadLine());
            int zahl8 = Convert.ToInt32(Console.ReadLine());

            //Berechnung der Zwei zahlen

            int Summe3 = zahl7 / zahl8;

            //Ausgabe der erechneten zahl
            Console.WriteLine($"Die zahl  {zahl7} durch {zahl8} ergibt {Summe3}");

            #endregion
        }
    }
}
