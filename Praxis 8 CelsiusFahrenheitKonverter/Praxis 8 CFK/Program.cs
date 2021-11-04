using System;

namespace Praxis_8_CFK
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abfrage zu Eingabe von Grad Celsius
            double Celsius = Convert.ToDouble(Console.ReadLine());

            //Berechnung der eingabe von Celsius in Fahrenheit
            double f = (Celsius * 9 / 5 + 32);

            //Ausgabe der Eingabe von Celsius in fahrenheit
            Console.WriteLine($"Es waren {Celsius} grad Celsius und das entsprechen {f} grad fahrenheit");


            //Formatirte ausgabe
            Console.WriteLine($"{Celsius:F} = {f:F}");   //   :F   /Zwei nachkommastellen
            Console.WriteLine($"{Celsius:F1} = {f:F1}"); //   :F1 / Diereckte angabe der nachkommastellen



        }
    }
}
