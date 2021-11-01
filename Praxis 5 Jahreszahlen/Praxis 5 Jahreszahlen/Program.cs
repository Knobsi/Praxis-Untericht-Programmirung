using System;

namespace Praxis_5_Jahreszahlen
{
    class Program
    {
        static void Main(string[] args)
        {

            //Frage
            Console.Write("Welches jahr Haben wir ? ");

            //Eingabe
            int jahreszahl = Convert.ToInt32(Console.ReadLine());

            //Ausrechnen
            int jahrhundert = jahreszahl / 100 +1;
            int jahr = jahreszahl % 100;

            //Ausgabe
            Console.WriteLine(" Jahrhundert ist " + jahrhundert + " Und die jahreszahl ist " + jahr);

        }
    }
}
