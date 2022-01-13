using System;

namespace Aufgabenblatt6_pba3h21agi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lives = 3;
            int playerNum;

            Random myObject = new Random();
            int ranNum = myObject.Next(1, 10);
            Console.WriteLine(ranNum.ToString());

            Console.WriteLine("Geben sie eine nummer ein zwischen 1 und 10");
            playerNum = Convert.ToInt32(Console.ReadLine());

            while (playerNum != ranNum)
            {
                
                if (playerNum != ranNum && lives == 1)
                {
                    Console.WriteLine($"Sie haben verloren. {ranNum} wäre die gesuchte Zahl gewesen.");
                    break;
                }
                else if (playerNum != ranNum && lives > 1)
                {
                    if (playerNum < ranNum)
                    {
                        Console.WriteLine("Die gesuchte zahl ist größer");
                    }
                    else
                    {
                        Console.WriteLine("Die gesuchte zahl ist kleiner");
                    }
                    lives--;

                    Console.WriteLine("Geben sie eine nummer ein zwischen 1 und 10");
                    playerNum = Convert.ToInt32(Console.ReadLine());
                }
            }
            if (playerNum == ranNum)
            {
                Console.WriteLine($"Sie haben das Spiel mit {lives} Leben gewonnen.");
            }
        }
    }
}
