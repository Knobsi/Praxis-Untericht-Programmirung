//Autor : Leon Gießelmann
using System;

namespace _4b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char next = ' ';
            while (next == ' ')
            {
                Console.Write("Jahr ? :");
                int jahr = Convert.ToInt32(Console.ReadLine());
                Console.Write("Monat ? :");
                int monat = Convert.ToInt32(Console.ReadLine());
                Console.Write("Tag ? :");
                int tag = Convert.ToInt32(Console.ReadLine());
                tag -= 1;

                int wochenTag = BerechneWochentag(jahr, monat, tag);
                tag += 1;
                switch (wochenTag)
                {
                    case 0:
                        Console.WriteLine($"Der {tag}.{monat}.{jahr} ist ein Montag");
                        break;
                    case 1:
                        Console.WriteLine($"Der {tag}.{monat}.{jahr} ist ein Dienstag");
                        break;
                    case 2:
                        Console.WriteLine($"Der {tag}.{monat}.{jahr} ist ein Mitwoch");
                        break;
                    case 3:
                        Console.WriteLine($"Der {tag}.{monat}.{jahr} ist ein Donnerstag");
                        break;
                    case 4:
                        Console.WriteLine($"Der {tag}.{monat}.{jahr} ist ein Freitag");
                        break;
                    case 5:
                        Console.WriteLine($"Der {tag}.{monat}.{jahr} ist ein Samstag");
                        break;
                    case 6:
                        Console.WriteLine($"Der {tag}.{monat}.{jahr} ist ein Sontag");
                        break;
                }

                Console.WriteLine("Um eine erneute abfrage zu starten bitte lertaste drücken ansonsten eine andere taste");
            }
            
        }

        public  static int BerechneWochentag( int jahr,  int monat, int tag)
        {

            if (monat == 1)
            {
                monat = 13;
                jahr = jahr - 1;
            }
            else if (monat == 2)
            {
                monat = 14;
                jahr = jahr - 1;
            }


            int jahrhundert = jahr / 100;
            jahr = jahr % 100;
            int w = (tag + (26 * (monat + 1)) / 10 + (5 * jahr) / 4 + jahrhundert / 4 + 5 * jahrhundert - 1) % 7;


            return w;
        }
    }
}

