using System;

namespace Aufgabe_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region A
            Console.WriteLine("Wie groß soll das object sein");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;

            for (int i = 1; i <= n; i++)
            {
                for (int b = 1; b <= n; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion
            #region B
            n = temp -1;
            int loch = n;
            for (int i  = 1; i <= n+1 ; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 1; i < n; i++)
            {
                Console.Write('*');
                for (int b = 1; b <= n -1; b++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
            }
            for (int i = 1; i <= n+1 ; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            #endregion
        }
    }
}
