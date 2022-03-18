using System;

namespace Praxis_38_Rechteck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rechteck r1 = new Rechteck(8, 9.2);
            Rechteck r2 = new Rechteck(8);

            double r1Flaeche = r1.BerechneFlaeche();
            double r2Flaeche = r2.BerechneFlaeche();

            double r1Umfang = r1.BerechneUmfang();
            double r2Umfang = r2.BerechneUmfang();

            double r1Diagonale = r1.BerechneDiagonale();
            double r2Diagonale = r2.BerechneDiagonale();

            Console.WriteLine(r1 +$"Fläche = {r1Flaeche:F} Umfang = {r1Umfang:F} Diagonale = {r1Diagonale:F}");
            Console.WriteLine(r2 +$"Fläche = {r2Flaeche:F} Umfang = {r2Umfang:F} Diagonale = {r2Diagonale:F}");
        }
    }
}
