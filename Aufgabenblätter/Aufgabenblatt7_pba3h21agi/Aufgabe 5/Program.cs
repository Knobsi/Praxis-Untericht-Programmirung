using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {


            char vorne = '/';
            char hinten = '\\';
            char zwischen = '|';
            char baumStamm = '|';

            Console.WriteLine("Hier sind ein paar schöne beispiel sätze  15 und 5  oder 32 und 11");

            Console.WriteLine("Geben sie bitte die baum größe ein");
            int baumLaenge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben sie bitte die stamm länge ein ( Für eine optimale darstellung bitte eine ungerade zahl )");
            int stamLaenge = Convert.ToInt32(Console.ReadLine());


            for (int s = 0; s < baumLaenge; s++)
            {

                if (s == baumLaenge - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" *");
                    Console.Write("\n");

                }
                else
                {
                    Console.Write(" ");
                }

            }

            for (int i = 1; i < baumLaenge; i++)
            {

                for (int d = baumLaenge; d > i; d--)
                {
                    Console.Write(" ");
                }

                for (int b = 0; b < i; b++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(vorne);


                }
                Console.Write(zwischen);
                for (int c = 0; c < i; c++)
                {
                    Console.Write(hinten);


                }
                Console.Write("\n");
            }

            for (int sl = 0; sl < stamLaenge / 2; sl++)
            {

                for (int bw = 0; bw < baumLaenge - (stamLaenge / 2); bw++)
                {
                    Console.Write(" ");
                }
                for (int w = 0; w < stamLaenge; w++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(baumStamm);
                }
                Console.Write("\n");

            }
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("        /'\\_/`\\ \n");
            Console.Write("       /\\      \\     __   _ __   _ __   __  __    \n");
            Console.Write("       \\ \\ \\__\\ \\  /'__`\\/\\`'__\\/\\`'__\\/\\ \\/\\ \\ \n");
            Console.Write("        \\ \\ \\_ /\\\\/\\  __/\\ \\ \\/ \\ \\ \\/ \\ \\ \\_\\ \\ \n");
            Console.Write("         \\ \\_\\ \\_\\\\____\\ \\_\\  \\ \\_\\  \\ /`____   \\ \n");
            Console.Write("          \\/_/ \\/_/\\/____/ \\/_/   \\/_/     `/___/   \n");
            Console.Write("                                           /\\___/  \n");
            Console.Write("                                           \\/__/ \n");
            
            Console.Write("  /\\  _`\\  /\\ \\             __         /\\ \\__                                \n");
            Console.Write("  \\ \\ \\ /\\_\\ \\ \\___   _ __ /\\_\\    ____\\ \\ ,_\\   ___ ___      __      ____  \n");
            Console.Write("   \\ \\ \\ /_/_\\ \\  _`\\/\\`'__\\/\\ \\  /',__\\ \\ \\/ /' __` __`\\  /'__`\\   /',__\\ \n");
            Console.Write("    \\ \\ \\_\\ \\ \\ \\ \\ \\ \\ \\/ \\ \\ \\/\\__, `\\ \\ \\_/\\ \\/\\ \\/\\  \\/\\ \\_\\.\\_/\\__, `\\ \n");
            Console.Write("     \\ \\____/ \\ \\_\\ \\_\\ \\_\\  \\ \\_\\/\\____/ \\ \\__\\ \\_\\ \\_\\ \\_\\ \\__/.\\_\\/\\____/ \n");
            Console.Write("      \\/___/   \\/_/\\/_/\\/_/   \\/_/\\/___/   \\/__/\\/_/\\/_/\\/_/\\/__/\\/_/\\/___/  \n");

            Console.ResetColor();
        }
    }
}