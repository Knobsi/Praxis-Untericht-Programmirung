//Autor : Leon Gießelmann
using System;

namespace Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Summe(1,5));
        }

        public static int Summe(int x, int y)
        {
            int sum = 0;
            for (int i = x; i <= y; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
