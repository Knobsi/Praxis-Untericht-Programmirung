using System;

namespace Praxis_18_Quersummen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl = Convert.ToInt32(Console.ReadLine());
            int temp = zahl;
            int quersumme = 0;

            while (zahl != 0)
            {
                int last = zahl % 10;
                quersumme = quersumme + last;
                zahl = zahl / 10;
                Console.Write(quersumme);
                Console.Write(".");
            }

            zahl = temp;
            /*

            do
            {
                int last = zahl % 10;
                quersumme = last;
                zahl = zahl / 10;
                Console.WriteLine(quersumme);
            } while (zahl != 0);
            */
        }
    }
}
