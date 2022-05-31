using System;
using System.Collections.Generic;

namespace Aufgabenblatt14_pba3h21agi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HighscoreManager hm = new HighscoreManager();

            Print(hm.GetTopTen());

        }
        static void Print(List<Highscore> highscoreList)
        {
            Console.WriteLine($"| {"#",-2} | {"Player",-20} | {"Score",-10} |");
            Console.WriteLine($"------------------------------------------");
            for (int i = 0; i < highscoreList.Count; i++)
            {
                Console.WriteLine($"| {i+1,-2} | {highscoreList[i].Player,-20} | {highscoreList[i].Score,-10} |");
            }
        }
    }
}
