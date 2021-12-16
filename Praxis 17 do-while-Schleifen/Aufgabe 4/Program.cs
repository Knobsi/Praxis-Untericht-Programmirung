using System;
//Berechnung der Fakultät (siehe 5-3)
namespace Aufgabe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eingabe = Convert.ToInt32(Console.ReadLine());
            int fakultaet = 1;
            int lauf = 1;

            do 
            {

                fakultaet = fakultaet * lauf;
                Console.WriteLine("Die Fakultät von " + lauf + " lautet: " + fakultaet);
                lauf++;
                
            }
            while (lauf <= eingabe);
            Console.WriteLine("Die Fakultät von " + eingabe + " lautet: " + fakultaet);
        }
    }
}
