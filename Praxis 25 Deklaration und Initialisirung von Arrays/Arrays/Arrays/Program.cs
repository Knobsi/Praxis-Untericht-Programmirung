using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Int zahlen und ausgabe
            int[] zahlen = { 4, 2, 10, 3, -5, 0, 17 };
            for(int i = 0; i < zahlen.Length; i++)
            {
                Console.Write(zahlen[i] + "\t");
            }
            Console.WriteLine("\n");

            // double temperaturen und ausgabe
            double[] temperaturen = { 9.8, 2.4, 5.6, 10.3, 4.9 };
            for(int i = 0;i < temperaturen.Length; i++)
            {
                Console.Write(temperaturen[i] + "\t");
            }
            Console.WriteLine("\n");

            //string wochntage
            string[] wochentage = { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sontag" };
            for(int i = 0;i<wochentage.Length; i++)
            {
                Console.Write(wochentage[i] + "\t");
            }
            Console.WriteLine("\n");

            //char bustaben
            char[] buchstaben = new char[26];
            for(int i = 0; i < 26 ; i++)
            {
                buchstaben[i] = Convert.ToChar(i + 97);
                Console.Write(buchstaben[i] + "\t");
            }
            Console.WriteLine("\n");

            //int gearadezahl
            int[] gearadeZahl = new int[50];
            for(int i = 0 ; i <= gearadeZahl.Length;i++)
            {
                Console.Write((gearadeZahl[i] = i *2 ) + "\t");
            }
            Console.WriteLine("\n");

            //int zufallsZahl
            Random r = new Random();
            int[] zufallsZahl = new int[100];
            for(int i = 0 ;i < zufallsZahl.Length ; i++)
            {
                int a = r.Next(1,10);
                Console.Write((zufallsZahl[i] = a) + "\t");
            }
        }
    }
}
