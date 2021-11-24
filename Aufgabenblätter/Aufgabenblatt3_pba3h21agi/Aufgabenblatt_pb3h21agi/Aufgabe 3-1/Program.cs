// Autor : Leon.Gießelmann
using System;

namespace Aufgabe_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gebe den wert in Celsius ein");
            double celsius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Gebe den wert in fahrenheit ein");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben sie ein c ein wen sie celsius in fahrenheit umrechnen wollen oder ein f wen sie fahrenheit in celsius umrechnen wollen");
            string fOderC = Console.ReadLine();

            if(fOderC == "c"||fOderC == "C")
            {
        
                celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"Die angegebenen {fahrenheit}°Fahrenheit entsprechen {celsius}°Celsius");

            }
            else if(fOderC == "f"||fOderC == "F")
            {
                
                fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine($"Die angegebenen {celsius}°Celsius entsprechen {fahrenheit}°Fahrenheit");

            }
            else
            {

                Console.WriteLine("Sie haben einen faltschen wert eingegeben bitte enter drücken zum wiederholen");
                Console.ReadKey();
                Program.Main(args);
                    
            }

        }
    }
}
