using System;
using System.Collections.Generic;

namespace Praxis_52_SackBahnhof
{
    internal class Program
    {
        static Stack<Wagon> gleisA = new Stack<Wagon>();
        static Stack<Wagon> gleisB = new Stack<Wagon>();
        static Stack<Wagon> gleisC = new Stack<Wagon>();

        

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                if(random.Next(0,2) == 0)
                {
                    if(random.Next(0,2) == 0)
                    {
                        gleisB.Push(new Wagon("A"));
                    }
                    else
                    {
                        gleisB.Push(new Wagon("B"));
                    }
                }
                else
                {
                    if (random.Next(0, 2) == 0)
                    {
                        gleisC.Push(new Wagon("A"));
                    }
                    else
                    {
                        gleisC.Push(new Wagon("B"));
                    }
                }
            }

            Console.WriteLine("A = " + String.Join("|",gleisA));
            Console.WriteLine("B = " + String.Join("|", gleisB));
            Console.WriteLine("C = " + String.Join("|", gleisC));

            Console.WriteLine($"Es gibt {gleisA.Count} Wagons in Gleis A und {gleisB.Count} Wagons in Gleis B");
        }
        static void SortiereWagons()
        {
            Console.WriteLine("Welche Wagons (Buchtabe) Sollen auf welches gleis(Buchstabe)");
            Console.WriteLine("Geben sie nun bitte die buchstaben ein es gibt gleis A B und C und wagons A und B");
            string sortierNum = Console.ReadLine();
            sortierNum = sortierNum.ToLower();
            char[] sortChar = sortierNum.ToCharArray();
            if(sortChar[0]=='a'|| sortChar[0] == 'b' || sortChar[0] == 'c' && sortChar[1]=='a'|| sortChar[1] == 'b')
            {
                Sort(sortChar[0], sortChar[1]);
            }
            else
            {
                throw new Exception("Den angegebenen Bahnhof gibt es nicht");
            }
        }
        static void Sort(char Bahnhoff , char Wagon)
        {
            while (gleisB.Count > 0)
            {
                if (gleisB.Peek().ZielBahnhof == "A")
                {
                    gleisA.Push(gleisB.Pop());
                }
                else
                {
                    gleisC.Push(gleisB.Pop());
                }
            }

            while (gleisC.Count > 0)
            {
                if (gleisC.Peek().ZielBahnhof == "A")
                {
                    gleisA.Push(gleisC.Pop());
                }
                else
                {
                    gleisB.Push(gleisC.Pop());
                }
            }
        }
    }
}
