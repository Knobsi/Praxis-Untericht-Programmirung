using System;

namespace g
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double sum = 0;
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                sum = sum + 1d / i;
            }
            Console.WriteLine($"{sum:F}");
        }
    }
}
