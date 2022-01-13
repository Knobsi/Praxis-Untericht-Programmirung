using System;

namespace Praxis_21_Ein_mal_eins
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int i = 1; i <= 10; i++)
            {

                for (int a = 1; a <= 10; a++)
                {
                    
                    Console.Write(i * a + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
