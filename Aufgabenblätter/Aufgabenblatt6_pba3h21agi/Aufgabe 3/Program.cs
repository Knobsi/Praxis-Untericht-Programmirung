using System;

namespace Aufgabe_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerCount = 0;

            Random myObject1 = new Random();
            int ranNum = myObject1.Next(16, 22);

            Random myObject2 = new Random();
            int card = myObject2.Next(2, 12);
            Console.WriteLine(card.ToString());


            playerCount = playerCount + card;

            Console.Write("Sagen sie bitte [s] Stop oder [w] Weiter");
            char run = Convert.ToChar(Console.ReadLine());

            while ( run == 'w')
            {
               
                card = myObject2.Next(2, 12);
               

                playerCount = playerCount + card;
                Console.WriteLine(playerCount);

                Console.Write("Sagen sie bitte [s] Stop oder [w] Weiter");
                run = Convert.ToChar(Console.ReadLine());
            }

            if(run == 's')
            {
                if(playerCount == 21)
                {
                    Console.WriteLine("Gewonnen");
                }
                else if(playerCount > 21)
                {
                    Console.WriteLine("Verloren");
                }
                else if(playerCount > ranNum)
                {
                    Console.WriteLine("Verloren");
                }
                else if(playerCount < ranNum)
                {
                    Console.WriteLine("Gewonnen");

                }
                else if(playerCount == ranNum)
                {
                    Console.WriteLine("Unentschieden");
                }
            }


        }
    }
}
