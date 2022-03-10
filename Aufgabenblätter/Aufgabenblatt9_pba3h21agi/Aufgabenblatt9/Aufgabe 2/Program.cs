//Autor : Leon Gießelmann
using System;

namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Random r = new Random();
            for (int i = 0;i<array.Length;i++)
            {
                array[i] = r.Next(1,100);
            }
            
            Console.Write("[");
            foreach(int i in array)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine("]");
        }
    }
}
