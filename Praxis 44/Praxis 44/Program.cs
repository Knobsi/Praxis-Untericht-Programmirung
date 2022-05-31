using System;
using System.IO;
using System.Text;

namespace Praxis_44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = ImportArtikel();

            int[] artikelnr = new int[lines.Length];
            int[] lagerbestand = new int[lines.Length];
            double[] preis = new double[lines.Length];
            string[] bezeichner = new string[lines.Length];
            string[] kategorie = new string[lines.Length];
            string[] farbe = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                artikelnr[i] = Convert.ToInt32(lines[i].Trim('-').Substring(0,8));
            }
            Console.WriteLine(artikelnr[0]);

           


        }

        public static string[] ImportArtikel()
        {
            return File.ReadAllLines(@"C:\Users\bib\OneDrive - bib & FHDW\Desktop\Schule\Semester 1\Untericht\Programmierung\Praxis\Praxis 44\Praxis 44\Artikelliste.csv", Encoding.Default);
        }
    }
}
