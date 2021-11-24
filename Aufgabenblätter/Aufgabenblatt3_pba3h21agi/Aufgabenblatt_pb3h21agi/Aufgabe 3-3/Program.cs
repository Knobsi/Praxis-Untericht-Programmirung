// Autor : Leon.Gießelmann
using System;

namespace Aufgabe_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wie viel kostet ein stück der ware" );
            double stückPreis = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wieviel wollen sie haben" );
            int stückzahl = Convert.ToInt32(Console.ReadLine());

            double ohneRabat;
            double summe ;
            double prozentPreis;

            double gesammtPreis;
            

            if(stückzahl > 100 && stückzahl < 200)
            {
                gesammtPreis = stückPreis * stückzahl;
                summe = gesammtPreis / 100 * 98;
                prozentPreis = gesammtPreis / 100 * 2;
                Console.WriteLine($"Der verkaufspreis ohne rabat ist {gesammtPreis} der rabatspreis ist {prozentPreis } und der preis mit rabat ist { summe}");
            }
            else if (stückzahl > 200 && stückzahl < 500)
            {
                gesammtPreis = stückPreis * stückzahl;
                summe = gesammtPreis / 100 * 97;
                prozentPreis = gesammtPreis / 100 * 3;
                Console.WriteLine($"Der verkaufspreis ohne rabat ist {gesammtPreis} der rabatspreis ist {prozentPreis } und der preis mit rabat ist { summe}");
            }
            else if (stückzahl > 500 && stückzahl < 1000)
            {
                gesammtPreis = stückPreis * stückzahl;
                summe = gesammtPreis / 100 * 95;
                prozentPreis = gesammtPreis / 100 * 5;
                Console.WriteLine($"Der verkaufspreis ohne rabat ist {gesammtPreis} der rabatspreis ist {prozentPreis } und der preis mit rabat ist { summe}");
            }
            else if (stückzahl > 1000 )
            {
                gesammtPreis = stückPreis * stückzahl;
                summe = gesammtPreis / 100 * 90;
                prozentPreis = gesammtPreis / 100 * 10;
                Console.WriteLine($"Der verkaufspreis ohne rabat ist {gesammtPreis} der rabatspreis ist {prozentPreis } und der preis mit rabat ist { summe}");
            }
           

            
        }
    }
}
