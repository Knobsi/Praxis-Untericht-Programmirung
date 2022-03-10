using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 2, 1, 2, 1, 1, 1, 1, 1, 2, 2, 3, 4, 5, 1, 1, 2 };
            int x = 2;

            int heufigkeit = ErmittleHeufigkeit(array, x);
            Console.WriteLine("Heufigkeit "+heufigkeit);
        }
        static int ErmittleHeufigkeit(int[] array,int x)
        {
            int heufigkeit = 0;

            foreach(int i in array)
            {
                if(i == x)
                    heufigkeit++;
            }

            return heufigkeit;
        }
    }
}
