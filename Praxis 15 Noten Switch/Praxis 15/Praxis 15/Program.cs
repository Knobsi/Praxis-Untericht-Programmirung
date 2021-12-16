using System;

namespace Praxis_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int note;

            Console.Write("Was ist deine note :");
            note = Convert.ToInt32(Console.ReadLine());

            switch (note)
            {
                case 1:
                    Console.WriteLine(note);
                    break;
                case 2:
                    Console.WriteLine(note);
                    break;
                case 3:
                    Console.WriteLine(note);
                    break;
                case 4:
                    Console.WriteLine(note);
                    break;
                case 5:
                    Console.WriteLine(note);
                    break;
                case 6:
                    Console.WriteLine(note);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(note + " rly nene die gibbet nich");
                    Main(args);
                    break;
            }
        }
    }
}
