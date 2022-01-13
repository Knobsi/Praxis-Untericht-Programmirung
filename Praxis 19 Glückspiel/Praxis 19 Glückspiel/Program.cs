using System;

namespace Praxis_19_Glückspiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char geschlecht;
            string name;
            int alter;
            int zahl;
            int quersumme = 0;

            Console.WriteLine("Wilkommen beim Zahlen Glückspiel");
            Console.Write("Wie heißen sie :");
            name = Console.ReadLine();
            Console.Write("Wie alt sind sie :");
            alter = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sind sie mänlich oder weiblich [m] oder [w]");
            geschlecht = Convert.ToChar(Console.ReadLine());
            


            if(alter > 18)
            {
                switch (geschlecht)
                {
                    case 'm':
                        Console.WriteLine("Wilkommen Herr " + name);
                        Console.Write("Geben sie eine zahl zwischen 1 und 10.000 ein ");
                        zahl = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 'w':
                        Console.WriteLine("Willkommen Frau " + name);
                        Console.Write("Geben sie eine zahl zwischen 1 und 10.000 ein ");
                        zahl = Convert.ToInt32(Console.ReadLine());
                        break ;
                    default:
                        Console.WriteLine("Wilkommen " + name);
                        Console.Write("Geben sie eine zahl zwischen 1 und 10.000 ein ");
                        zahl = Convert.ToInt32(Console.ReadLine());
                        break;
                }

                while (zahl < 1 || zahl > 10000)
                {
                    Console.Write("Ungültige eingabe bitte erneut eingeben :");
                    zahl = Convert.ToInt32(Console.ReadLine());
                }

                while (zahl != 0)
                {
                    int last = zahl % 10;
                    quersumme = quersumme + last;
                    zahl = zahl / 10;
                }

                if (quersumme % 2 != 0 && quersumme % 9 == 2 && quersumme % 7 == 1)
                {
                    Console.WriteLine("Sie haben 100 Euro gewonnen");
                }
                else
                {
                    Console.WriteLine("Sie haben leider verloren");
                }

            }
            else
            {
                Console.WriteLine("Die teilname am glückspiel ist erst ab 18");
            }
        }
    }
}
