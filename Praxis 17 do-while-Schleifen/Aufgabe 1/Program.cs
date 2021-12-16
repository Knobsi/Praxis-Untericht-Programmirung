using System;
//Ausgabe der zahlen 1 bis 10 auf der Konsole
namespace Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            }
                while (i <= 10) ;
        }
    }
}
