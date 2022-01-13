using System;

namespace Uebung22_WdhKontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {

            #region if-else
            Console.Write("Zahl");
            int zahl = Convert.ToInt32(Console.ReadLine());

            //ToDo Ausgabe Zahl ist negativ, gleich 0 bzw. positiv

            if(zahl == 0)
            {
                Console.WriteLine("Jo hier ist die zahl 0");
            }
            else if(zahl < 1)
            {
                Console.WriteLine("Zahl kleiner 0");
            }
            else
            {
                Console.WriteLine("Zahl größer 0");
            }

            #endregion

            #region switch case
            Console.Write("Wochentag (1 (mo), 2 (di), ...., 7 (so)? : ");
            int wochentag = Convert.ToInt32(Console.ReadLine());

            //ToDo Ausgabe Werktag, Sonntag bzw. Ungültige Eingabe
            switch(wochentag)
            {
                case 1:
                    Console.WriteLine("Werktag");
                    break;
                case 2:
                    Console.WriteLine("Werktag");
                    break;
                case 3:
                    Console.WriteLine("Werktag");
                    break;
                case 4:
                    Console.WriteLine("Werktag");
                    break;
                case 5:
                    Console.WriteLine("Werktag");
                    break;
                case 6:
                    Console.WriteLine("Samstag");
                    break;
                case 7:
                    Console.WriteLine("Sonntag");
                    break;
                default:
                    Console.WriteLine("Ungültige eingabe");
                    break;
            }
            #endregion

            #region while, do-while
            Console.Write("Startzahl:");
            int startzahl = Convert.ToInt32(Console.ReadLine());
            int summe = startzahl;

            //ToDo Addiere solange 10 auf die Startzahl bis die Summe 100 überschritten hat 
            //(while && do-while)

            while(summe < 100)
            {
                startzahl = startzahl + 10;
                summe = startzahl;
                Console.WriteLine(summe);
            }

            do
            {
                startzahl = startzahl + 10;
                summe = startzahl;
            }while(summe < 100);

            #endregion

            #region for-Schleife

            //ToDo Ausgabe der Zahlen 12 bis 24

            for (int i = 12; i <= 24; i++)
            {
                Console.WriteLine(i);
            }

            #endregion
        }
    }
}
