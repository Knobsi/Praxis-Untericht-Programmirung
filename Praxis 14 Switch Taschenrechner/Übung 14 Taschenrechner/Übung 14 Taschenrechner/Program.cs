using System;

namespace Übung_14_Taschenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl1;
            int zahl2;
            int summe = 0;

            char oparator;


            Console.WriteLine("Dies ist ein Taschenrechner");
            Console.Write("Zahl 1:");

            zahl1 =Convert.ToInt32(Console.ReadLine());

            Console.Write("Zahl 2:");

            zahl2 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wie soll gerechnet werden + , - , * , / ");
            oparator = Convert.ToChar(Console.ReadLine());

            switch (oparator)
            {
                case '+':
                    summe = zahl1 + zahl2;
                    break;
                case '-':
                    summe = zahl1 - zahl2;
                    break;
                case '*':
                    summe = zahl1 * zahl2;
                    break;
                case'/':
                    summe = zahl1 / zahl2;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Falsche angabe getahn programm wird neugestartet");
                    System.Threading.Thread.Sleep(1000);
                    Main(args);
                    break;
            }
            Console.WriteLine($"{zahl1} {oparator} {zahl2} ergeben {summe}");
        }
    }
}
