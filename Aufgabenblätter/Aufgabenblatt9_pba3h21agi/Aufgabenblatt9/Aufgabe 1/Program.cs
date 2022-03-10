//Autor : Leon Gießelmann
using System;

namespace Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double durchschnit = 0;

            Console.Write("Menge der Noten ? : ");
            int arrayGroeße = Convert.ToInt32(Console.ReadLine());

            double[] arrray = new double[arrayGroeße];

            for (int i = 0; i < arrray.Length; i++)
            {
                Console.Write($"Welche Zahl kommt als {i + 1}te Note : ");
                arrray[i] = Convert.ToDouble(Console.ReadLine());
                durchschnit += arrray[i];
            }

            durchschnit = durchschnit / arrray.Length;

            Console.WriteLine($"Der durchschnit ist {durchschnit:F1}" );


        }
    }
}
