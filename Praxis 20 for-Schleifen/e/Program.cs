using System;

namespace e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summe = 1;
            Console.Write("Fakultät von n: ");
            

            for (int n = Convert.ToInt32(Console.ReadLine()); n  > 1;n --)
            {
                summe *= n;
                Console.WriteLine(summe);
            }


        }
    }
}
