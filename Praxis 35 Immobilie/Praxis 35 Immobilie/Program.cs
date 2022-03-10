using System;

namespace Praxis_35_Immobilie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Immobilie hausEins = new Immobilie("Doppelhaushälfte innenstadt Nah", 110, 5, 1977, 210000,true);
            Immobilie hausZwei = new Immobilie("Traumhaus am waldrand",165,8,205,650000,false);
            Immobilie hausDrei = new Immobilie("geiloBude", 1655, 69, 0, 42069, false);

            Console.WriteLine(hausEins);
            Console.WriteLine(hausZwei);
            Console.WriteLine(hausDrei);

        }
    }
}
