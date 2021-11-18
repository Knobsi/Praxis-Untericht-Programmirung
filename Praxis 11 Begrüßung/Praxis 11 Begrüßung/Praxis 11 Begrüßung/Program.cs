using System;

namespace Praxis_11_Begrüßung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name bitte! : ");
            string name = Console.ReadLine();

            Console.Write("vorname bitte! : ");
            string vorname = Console.ReadLine();

            Console.Write("Geschlecht in form von m oder w oder d bitte : ");
            string geschlecht = Console.ReadLine();

            if(geschlecht == "m" || geschlecht == "M")
            {
                Console.WriteLine($"Hallo Herr {name}!");
            }
            else if(geschlecht == "w" || geschlecht == "W")
            {
                Console.WriteLine($"Hallo Frau {name}!");
            }
            else if(geschlecht == "d" || geschlecht == "D")
            {
                Console.WriteLine($"Hallo {vorname} {name}");
            }
            else
            {
                Console.WriteLine("Enter drücken zum Neufersuch deine eingabe war nicht m,w,d");

                string neustart = Console.ReadLine();


                if (neustart == neustart)
                {
                    Console.Clear();
                    Program.Main(args);
                }

            }
        }
    }
}
