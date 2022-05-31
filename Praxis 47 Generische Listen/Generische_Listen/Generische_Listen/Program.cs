using System;
using System.Collections.Generic;

namespace Generische_Listen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> pizzas = new List<Pizza>();
            pizzas.Add(new Pizza("Margherita", 0, 5));
            pizzas.Add(new Pizza("Prosciutto", 1, 5.5));
            pizzas.Add(new Pizza("Tonno", 2, 6.5));
            pizzas.Add(new Pizza("Vier Jahreszeiten", 4, 7));
            pizzas.Add(new Pizza("Tri Colore", 3, 6.5));
            pizzas.Add(new Pizza("La Mamma", 4, 7));
            pizzas.Add(new Pizza("Gamba", 2, 9));
            pizzas.Add(new Pizza("Frutti di Mare", 6, 7));


            print(pizzas);
            //Sort
            pizzas.Sort(compareAnzahlZutaten);
            pizzas.Sort(CompareName);
            print(pizzas);
        }

        private static int CompareName(Pizza x, Pizza y)
        {
            return x.Name.CompareTo(y.Name);
        }

        private static int compareAnzahlZutaten(Pizza x, Pizza y){
            return x.AnzahlZutaten.CompareTo(y.AnzahlZutaten);
        }

        private static void print(List<Pizza> pizzas)
        {
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*                          Pizzakarte Ristorante bib                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine($"| {"NR"} | {"Name",-20} | {"#"} | {"Preis 20 cm",-11} | {"Preis 30 cm,",-11} | {"Preis 40 cm",-11} |");

            for (int i = 0; i < pizzas.Count; i++)
            {
                Console.WriteLine($"| {i + 1:D2} | {pizzas[i].Name,-20} | {pizzas[i].AnzahlZutaten} | {pizzas[i].Preis,-11} | {pizzas[i].Preis,-11}  | {pizzas[i].Preis,-11} |");
            }
        }
    }
}
