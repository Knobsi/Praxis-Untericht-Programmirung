using System;

namespace Praxis_29_Widerholung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double summe = 0;
            double mittelwert = 0;
            double maxWert = 0;
            double minWert = 0;

            double[] arr = new double[100];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.NextDouble();
                summe += arr[i];

                if(arr[i] > maxWert)
                {
                    maxWert = arr[i];
                }

                if(arr[i] < minWert)
                {
                    minWert = arr[i];
                }


            }
            mittelwert = summe / arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]:F3}");
                if (arr[i] <= arr.Length - 1)
                    Console.Write("|");
                
            }
            Console.WriteLine();
            Console.WriteLine($"Summe = {summe:F3}");
            Console.WriteLine($"Mittelwert = {mittelwert:F3}");
            Console.WriteLine($"Minimum = {minWert:F3}");
            Console.WriteLine($"Maximum = {maxWert:F3}");
        }
    }
}
