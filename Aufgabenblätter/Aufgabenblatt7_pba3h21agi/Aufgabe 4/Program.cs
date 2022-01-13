using System;

namespace Aufgabe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region A
            for (int i = 1; i <= 5; i++)
            {
                for (int b = 0; b < i; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
            #region B
            for (int i = 5; i >= 1; i--)
            {
                for (int b = i; b != 0; b--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
            #region C
            for (int i = 1; i <= 5; i++)
            {
                for (int c = i; c != 1; c--)
                {
                    Console.Write(" ");
                }
                for (int b = i; b >= i; b--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            #endregion
            #region D
            for (int i = 1; i <= 5; i++)
            {
                for (int c = i; c <= 5; c++)
                {
                    Console.Write(" ");
                }
                for (int b = i; b >= i; b--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            #endregion
        }
    }
}
