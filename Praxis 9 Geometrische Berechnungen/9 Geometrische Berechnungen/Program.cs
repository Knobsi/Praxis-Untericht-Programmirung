using System;

namespace _9_Geometrische_Berechnungen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anfrage des Radius vom Kreis
            Console.WriteLine("Welchen radius hat dein kreis? ");
            double r = Convert.ToDouble(Console.ReadLine());

            //Rechnung vom Umfang dr Fläche und dem Volumen
            double u = 2 * Math.PI * r;
            double f = Math.PI * Math.Pow(r,2);
            double v = 4d / 3 * Math.PI * Math.Pow(r,3);

            //Ausgabe aller ausgerechneten Geometrien
            Console.WriteLine($"r ist {r:F2}, u ist {u:F2}, f ist {f:F2} und v ist {v:F2}");
        }
    }
}
