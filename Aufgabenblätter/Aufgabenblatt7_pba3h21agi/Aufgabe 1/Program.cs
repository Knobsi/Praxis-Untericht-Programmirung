using System;

namespace Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("start? ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ende? ");
            int end = Convert.ToInt32(Console.ReadLine());
            

            for (int i = n; i <= end; i++)
            {
                char c =Convert.ToChar(i + 64);
                Console.WriteLine($"Die {i} ist {c}");
            }
        }
    }
}
