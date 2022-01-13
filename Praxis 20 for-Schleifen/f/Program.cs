using System;

namespace f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 65; i < 91; i++)
            {
                char num = Convert.ToChar(i);
                Console.WriteLine(num);
            }
        }
    }
}
