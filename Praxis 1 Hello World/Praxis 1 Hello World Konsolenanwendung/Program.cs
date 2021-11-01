using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Praxis_1_Hello_World_Konsolenanwendung
{
    class Program
    {
        
        
        static void Main(string[] args)
           {
            Image img = Image.FromFile();
            
            string körper;

            Console.Write("Dies ist etwas wie ein ");
            Console.WriteLine("Test");

            Console.Write("Wie ist ihr name ");
            string name = Console.ReadLine();

            Console.Write("Wie alt sind sie ");
            var alter = Console.ReadLine();


            Console.Write("Der name ist " + name);
            Console.WriteLine(" und er ist " + alter + " jahre alt");

            Console.WriteLine("Sind sie mänlich oder weiblich?  schreiben sie m oder w");
            string geschhlecht = Console.ReadLine();

            if( geschhlecht == "m" | geschhlecht == "M" )
            {
                Console.WriteLine("du hast nen dick");
                körper = "Man";
                Console.WriteLine("Oh sie sind es werter ritter sie sollten nun den bigbababubu boss fetzen");

            }
            else if(geschhlecht == "w" | geschhlecht == "W")
            {

                Console.WriteLine("Du bist ne bitsch");
                körper = "Frau";
                Console.WriteLine("Oh sie sind es werte ritterin sie sollten nun den bigbababubu boss fetzen");

            }
            else
            {

                Console.WriteLine("Geben sie Ihre geschlächt als m oder w an");
               

            }

            Console.WriteLine("Ihr boss heute ist ein Drache Lvl 20 er hat 150 leben und ist damit die größte ihrer herausforderungen");

            
           
        }
    }
}
