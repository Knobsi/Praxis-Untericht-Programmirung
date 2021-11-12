// Autor :Leon.Gießelmann
using System;

namespace Aufgabe_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Netto betrag in brutto betrag rechnen und merwertsteuer angeben

            //Aufforderung den netto betrag einzugeben
            Console.WriteLine("Geben sie den netto betrag des gegenstandes ein");
            double nettoBetrag = Convert.ToDouble(Console.ReadLine());


            //Ausrechnung der Merwertsteuer und des brutto betrages
            double merwertSteuer = nettoBetrag / 100 * 19;
            double bruttoBetrag = nettoBetrag + merwertSteuer;


            //Ausgabe des nettobetrags der werwertsteuer und des brutto betrags
            Console.WriteLine($"dein netto betrag ist{nettoBetrag:F} die merwertsteuer sind {merwertSteuer:F} und der bruttobetrag lautet{bruttoBetrag:F}");
        }
    }
}
