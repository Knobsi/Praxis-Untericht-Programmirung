// Autor :Leon.Gießelmann
using System;

namespace Aufgabe_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // sekunden in stunden minuten und rest sekunden ausgeben

            //Aufforderung einer eingabe
            Console.WriteLine("Geben sie sekunden ein die sie in stunden rest minuten und rest sekunden umrechnen wollen");
            int sekunden = Convert.ToInt32(Console.ReadLine());

            //Berechung der sekunden

            int stunden = sekunden / 3600;
            int reststunden = sekunden % 3600;

            int minuten = reststunden / 60;
            int restminuten = reststunden % 60;

            //Ausgabe der erechneten ergebnisse
            Console.WriteLine($" Deine eingegebenen {sekunden} sekunden sind ausgerechnet {stunden} stunden und {minuten} minuten und {restminuten}sekunden");

        }
    }
}
