using System;

namespace Praxis_36_Klasse_Würfel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fw2 = { 2, 2, 3, 3, 4, 4 };
            int[] fw3 = { 1, 2, 3, 4, 5, 6, 6, 6, 6, 6 };

            Wuerfel w1 = new Wuerfel();
            Wuerfel w2 = new Wuerfel(fw2);
            Wuerfel w3 = new Wuerfel(fw3);
            Wuerfel w4 = new Wuerfel(8);

            Console.WriteLine(w1);
            Console.WriteLine(w2);
            Console.WriteLine(w3);
            Console.WriteLine(w4);
            
        }
    }
}
