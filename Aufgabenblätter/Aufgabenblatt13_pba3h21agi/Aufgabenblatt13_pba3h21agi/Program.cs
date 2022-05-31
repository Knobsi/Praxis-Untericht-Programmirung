using System;
using System.Collections.Generic;

namespace Aufgabenblatt13_pba3h21agi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> leereListe = new List<int>();
            Console.WriteLine(leereListe.Count);
            Console.WriteLine(leereListe.Capacity);

            List<int> leereList = new List<int>();
            for (int i = 0; i < 1025; i++)
            {
                leereList.Add(i);
            }
            Console.WriteLine(leereList.Count);
            Console.WriteLine(leereList.Capacity);
        }
    }
}