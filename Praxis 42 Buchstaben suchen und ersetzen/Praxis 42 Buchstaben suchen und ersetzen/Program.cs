using System;

namespace Praxis_42_Buchstaben_suchen_und_ersetzen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Drei Chinesen mit dem Kontrabass saßen auf der Straße und erzählten sich was. Da kam die Polizei, fragt: "Was ist denn das?" Drei Chinesen mit dem Kontrabass.
            Console.WriteLine("Gebe mir einen text den du endern und buschstaben zählen lassen willst");
            string songText = Console.ReadLine();

            Console.WriteLine("Wieviele buchstaben wollen sie suchen ?");
            int wievielebuchstaben = Convert.ToInt32(Console.ReadLine());

            int[] buchstabenanzahl = new int[wievielebuchstaben];
            char[] charArray = new char[wievielebuchstaben];

            for (int i = 0; i < buchstabenanzahl.Length; i++)
            {
                Console.WriteLine("Welchen buchstaben wollen sie suchen?");
                char a = Convert.ToChar(Console.ReadLine());
                charArray[i] = a;
                buchstabenanzahl[i] = WieVielVonBustabe(a, songText);

                Console.Clear();
            }

            Console.WriteLine("Durch welchen buchstaben wolen sie die Vokale austauschen?");

            char tauscher = Convert.ToChar(Console.Read());
            string newText = VertauscheBuchstaben(tauscher, songText);

            Console.Clear();

            for (int i = 0; i < buchstabenanzahl.Length; i++)
            {
                Console.WriteLine($"Der buchstabe {charArray[i]} kamm {buchstabenanzahl[i]} mal vor");
            }

            Console.WriteLine($"\nDer text sieht nun dachdem der buchstabe {tauscher} getauscht wurde wie folgt aus\n");
            Console.WriteLine(newText);



        }
        static int WieVielVonBustabe(char a, string text)
        {
            int count;

            text = text.ToLower();
            a = Char.ToLower(a);

            count = text.Count(c => c == a);
            return count;
        }
        static string VertauscheBuchstaben(char a, string text)
        {
            text = text.Replace('a', a);
            text = text.Replace('e', a);
            text = text.Replace('i', a);
            text = text.Replace('o', a);
            text = text.Replace('u', a);
            return text;
        }
    }
}
