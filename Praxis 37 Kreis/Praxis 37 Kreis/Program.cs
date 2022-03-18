using System;

namespace Praxis_37_Kreis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kreis radius = new Kreis(50);
            double flaeche = radius.BerechneFlaeche();
            double umfang = radius.BerechneUmfang();
            double durchmesser = radius.BerechneDurchmesser();
            Console.WriteLine($" Der radius ist {radius:F} die fläche ist {flaeche:F} der umfang ist {umfang:F} und der durchmesser {durchmesser:F}");
        }
    }
}
