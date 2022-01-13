using System;

namespace d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summe = 0;
            for (int i = 0; i < 101; i++)
            {
                summe = summe + i;  
            }
            Console.WriteLine(summe);
        }
    }
}
