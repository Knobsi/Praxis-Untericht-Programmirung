using System;

namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

             Console.Write("Bitte Obergränze angeben:");
        int upperLimit = Convert.ToInt32(Console.ReadLine());
        Console.Write("Bitte Untergränze angeben:");
        int lowerLimit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bitte geben sie nach jedem versuch R, G oder K an. je nachdem ob \nR die Zahl richtig ist \nG die gesuchte Zahl grösser ist \nK die gesuchte Zahl kleiner ist");
        Random rnd = new Random(); 
        int ComputerGuess = rnd.Next(lowerLimit,upperLimit);
        int NumberOfTries = 1;
 
        while (true)
        {
 
            Console.WriteLine("Versuch {0}: {1}", NumberOfTries, ComputerGuess);
 
 
            string entry = Console.ReadLine();
             
            if (entry == "K" || entry =="k")
            {
                upperLimit = ComputerGuess - 1;
                ComputerGuess = rnd.Next(lowerLimit, ComputerGuess-1);
 
            }
            else if( entry =="G"|| entry == "g")
            {
                lowerLimit = ComputerGuess + 1;
                ComputerGuess = rnd.Next(ComputerGuess+1 , upperLimit);
                
            }
            else if(entry =="R" || entry == "r")
            {
                break;
            }
            if (lowerLimit == upperLimit)
            {
                ComputerGuess = upperLimit; 
                break;
            }
 
            NumberOfTries += 1;
             
        }
        Console.WriteLine("Die gesuchte Zahl war also die {0}!", ComputerGuess);

        }
    }
}
