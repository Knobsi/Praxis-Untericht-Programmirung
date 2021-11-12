// Autor : Leon.Gießelmann
using System;

namespace Aufgabe_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe A
            Console.WriteLine("Wie viele Galleonen wollen sie berechnen");
            int galleonen = Convert.ToInt32(Console.ReadLine());

            int sickel = galleonen * 17;
            int knuts = sickel * 29;


            Console.WriteLine($"Deine {galleonen} Galleonen ergeben entweder {sickel} sickel oder {knuts} knuts");


            //Aufgabe B

            int sickel2 = galleonen / 29;
            int sickelRest = galleonen % 29;
            int galleonen2 = sickel2 / 17;
            int galleonenRest = sickel2 % 17;

            Console.WriteLine($"Deine {galleonen} Galleonen entsprechen {galleonen2} galleonen {galleonenRest} sickel unt {sickelRest} knuts");
        }
    }
}
