//Autor : Leon Gießelmann
using System;

namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = ConvertToFahrenheit(36);
            Console.WriteLine(fahrenheit);
        }
        public static double ConvertToFahrenheit(double celsius)
        {

            double fahrenheit = (celsius * 9) / 5 + 32;

            return fahrenheit;
        }

    }
}
