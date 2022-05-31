using System;
using System.Collections.Generic;

namespace Praxis_46_List_Methoden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Liblingsessen = new List<string>();
            List<string> Musikgruppen = new List<string>();

            Liblingsessen.Add("Nudeln");
            Liblingsessen.Add("Tomaten");
            Liblingsessen.Add("Äpfel");
            
            Musikgruppen.Add("BLOBIS");
            Musikgruppen.Add("DROPSIS");
            Musikgruppen.Add("ABBA");
            Musikgruppen.Add("DROPSIS3");

            Musikgruppen.Sort();
            Console.WriteLine(string.Join("|", Musikgruppen));
            Console.WriteLine($"Das Element Blobis ist in der Liste an stelle {Musikgruppen.BinarySearch("ABBA") +1}");
            Musikgruppen.Insert(0, "BROGIS");

            Console.WriteLine("Im Folgendem wird die Liste Sorttiert sie sehen sie einmal unsortiert und danach sortiert Dies wird mit \"List\".Sort gemacht ");
            Console.WriteLine(string.Join("|", Musikgruppen));
            Musikgruppen.Sort();
            Console.WriteLine(string.Join("|", Musikgruppen));

            Musikgruppen.AddRange(Musikgruppen);
            Console.WriteLine(string.Join("|", Musikgruppen));

            Console.WriteLine(Musikgruppen.Contains("BLOBIS"));

            string[] blob = new string[] { "test", "lol" };

            Musikgruppen.InsertRange(5, blob);
            Console.WriteLine(string.Join("|", Musikgruppen));



        }
    }
}
