using System;

namespace Praxis_41_Chatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey wie gehts dir?");
            string s1 = Console.ReadLine();
            string[] gut = { "gut", "super", "supi", "geil", "ganz gut", "fein", "bestens" };

            string[] schlecht = { "schlecht", "nicht gut", "scheiße", "nicht so gut", "kacke" };

            for (int i = 0; i < gut.Length; i++)
            {
                bool g = s1.Contains(gut[i]);

                if (g)
                {
                    Console.WriteLine($"Das freut mich das es dir {gut[i]} geht! Was hast du denn heute bisher so schönes gemacht?\n(bitte in ganzen Sätzen mit mehr als 5 Wörtern antworten!!)");
                    Console.WriteLine($"Das eingabe wort {gut[i]} hast du ab zeichen {s1.LastIndexOf(gut[i])} verwendet");
                    Console.WriteLine($"Das eingabe wort {gut[i]} hast du ab zeichen {s1.IndexOf(gut[i])} verwendet");
                }
            }

            for (int i = 0; i < schlecht.Length; i++)
            {
                bool s = s1.Contains(schlecht[i]);

                if (s)
                {
                    Console.WriteLine($"Das ist schade das es dir {schlecht[i]} geht! Was ist denn passiert?\n(bitte in ganzen Sätzen mit mehr als 5 Wörtern antworten!!)");
                    Console.WriteLine($"Das eingabe wort {schlecht[i]} hast du ab zeichen {s1.IndexOf(schlecht[i])} verwendet");
                }
            }

            string antwort = Console.ReadLine();
            antwort = antwort.Remove(15);
            Console.WriteLine("ZzzzZzzz...");
            Console.WriteLine($"Boah ich hab nur aus Höflichkeit gefragt!! Mein Gott ey, nach \"{antwort}blablabla\" " +
                $"habe ich dir gar nicht mehr zugehört");
            Console.WriteLine("Du nervst echt, ich hoffe dir rutschen beim abspülen die Ärmel ins Wasser!!");

            Console.WriteLine("(Beleidigung wie \"trottel\", \"idiot\" oder \"blöde Kuh\" wird erwartet...)");
            string[] verboteneWoerter = new String[] { "trottel", "idiot", "blöde Kuh" };

            antwort = Console.ReadLine();
            string bla = "Tschüss!!";
            for (int i = 0; i < verboteneWoerter.Length; i++)
            {
                if (antwort.Contains(verboteneWoerter[i]))
                {
                    antwort = antwort.Replace(verboteneWoerter[i], "*****");
                    bla = $"Was soll den bitte {antwort} für eine Beleidigung sein? Bist du noch im Kindergarten?\n" +
           $"Das wird mir jetzt echt zu blöd hier, Tschüss!!";
                    break;
                }
            }
            Console.WriteLine(bla);



        }
    }
}
