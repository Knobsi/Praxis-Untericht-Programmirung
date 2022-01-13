using System;

namespace Praxis_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib eine zahl ein die als quersumme ausgerechnet werden soll ");
            

            for (int i = 1; i <= 100; i++)
            {
                int ausgabe = BerechneQuersumme(i);
                bool isHarshad = IsHarshadZahl(i, ausgabe);

                if (isHarshad)
                {
                    Console.WriteLine($"die zahl war {i} Quersumme ist {ausgabe} und es ist eine Harshad zahl");
                }
                else
                {
                    Console.WriteLine($"die zahl war {i} Quersumme ist {ausgabe} und es ist Keine Harshad zahl");
                }
            }
        }
        
        public static int BerechneQuersumme(int zahl)
        {
            int quersumme = 0;

            while(zahl != 0)
            {
                quersumme += zahl % 10;
                zahl /= 10;
            }
            return quersumme;
        }

        public static bool IsHarshadZahl(int zahl, int quersumme)
        {
            
            bool isHarshad = zahl % quersumme == 0;
            
            
            return isHarshad;
        }
    }
}
