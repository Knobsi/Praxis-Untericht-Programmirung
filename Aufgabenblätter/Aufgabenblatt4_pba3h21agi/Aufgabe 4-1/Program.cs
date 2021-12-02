// Autor : Leon Gießelmann
using System;

namespace Aufgabe_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Note ?");
            int note = Convert.ToInt32(Console.ReadLine()); 
            if(note == 1)
            {
                Console.WriteLine("Sehr gut");
            }
            else if(note == 2)
            {
                Console.WriteLine("Gut");
            }
            else if(note==3)
            {
                Console.WriteLine("Befriedigend");
            }
            else if(note ==4)
            {
                Console.WriteLine("Ausreichend");
            }
            else if(note == 5)
            {
                Console.WriteLine("Mangelhaft");
            }
            else if(note == 6)
            {
                Console.WriteLine("Ungenügend");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe!");
            }
        }
    }
}
