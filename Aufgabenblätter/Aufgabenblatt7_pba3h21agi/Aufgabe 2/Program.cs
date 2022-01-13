using System;

namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region A
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            for (int i = 1; i <= n; i++)
            {
                for (int b = 1; b <= i; b++)
                {
                    Console.Write(b);
                } 
               Console.WriteLine();
            }
            #endregion

            #region B
            n = temp;
            for (int i = 1; i <= n; i++)
            {

                for (int b = 0; b < i; b++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
