using System;

namespace Praxis_4_Gerechtes_Teilen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wieviele leute
            Console.Write("Wieviele Leute ? :");
            int leute = Convert.ToInt32(Console.ReadLine());

            // Wieviel Zeug
            Console.Write("Wieviel Zeugs ? :");
            int zeug = Convert.ToInt32(Console.ReadLine());

            // Ausrechnen
            int habenBeckommen = leute / zeug;
            int rest = leute % zeug;

            //Ausgabe
            Console.WriteLine(" es haben " + habenBeckommen + " etwas beckommen und es sind noch " + rest + " sachen über");

        }
    }
}
