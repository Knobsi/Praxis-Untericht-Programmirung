using System;
//Ausgabe eines Countdowns
namespace Aufgabe_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countdown = Convert.ToInt32(Console.ReadLine());

            

            do
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(countdown);
                countdown--;

            } while (countdown >= 0);
        }
    }
}
