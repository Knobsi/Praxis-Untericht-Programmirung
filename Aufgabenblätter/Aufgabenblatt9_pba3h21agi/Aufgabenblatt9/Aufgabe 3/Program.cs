//Autor : Leon Gießelmann
using System;

namespace Aufgabe_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1000];
            int wert = 0;

            Random r = new Random();

            foreach (int i in array)
            {
                array[i] = r.Next(1, 1001);
            }

            Console.Write("Welchen Zahl soll enthalten sein  : ");
            wert = Convert.ToInt32(Console.ReadLine());


            bool enthalten = Suche(array, wert);
            int index = SucheIndex(array, wert);
            int many = Heufigkeit(array, wert);

            if(enthalten)
            {
                Console.WriteLine($"Der wert {wert} war zum ersten mall an stelle {index} enthalten und kam insgesammt {many} mall vor");
            }
            else
            {
                Console.WriteLine("Der wert war nicht enthalten");
            }
        }

        public static bool Suche(int[] array, int wert)
        {
            bool ruckgabe = false;
            foreach(int i in array)
            {
                if(i == wert)
                    ruckgabe = true;
                else
                    ruckgabe = false;
            }
            return ruckgabe;
        }

        public static int SucheIndex(int[] array, int wert)
        {
            int tuck = -1;
           foreach(var i in array)
            { 
                if(array[i] == wert)
                { 
                    tuck = i;
                    break;
                }
            }
            return tuck;
        }

        public static int Heufigkeit(int[] array, int wert)
        {
            int heufigkeit = 0;
            foreach (int i in array)
            {
                if(i == wert)
                    heufigkeit++;

            }
            return heufigkeit;
        }

    }
}
