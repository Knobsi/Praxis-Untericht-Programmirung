// Autor : Leon Gießelmann
using System;

namespace Aufgabe_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Geben sie bitte ein jahr ein ");
            int year = Convert.ToInt32(Console.ReadLine());

            bool isLapYear = true;

            if ((year % 4) == 0)
            {
                if ((year % 100) == 0)
                    isLapYear = false;
                if ((year % 400) == 0)
                    isLapYear = true;
            }
            else
            {
                isLapYear = false;
            }
               
            if(isLapYear == true)
            {
                Console.WriteLine($"Das Jahr {year} ist Ein schaltjahr");
            }
            else
            {
                Console.WriteLine($"Das Jahr {year} ist Kein schaltjahr");
            }
        }
    }
}
