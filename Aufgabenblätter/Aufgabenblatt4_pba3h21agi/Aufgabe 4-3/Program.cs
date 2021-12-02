// Autor : Leon Gießelmann
using System;

namespace Aufgabe_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esIstNacht = true;

            Console.WriteLine("Geben sie die windstärke ein : ");
            byte windStaerke = Convert.ToByte(Console.ReadLine());

            Console.Write("Geben sie ein j ein wen es nacht ist und ein n wen es tag ist : ");
            string testDay = Console.ReadLine();

            if(testDay =="j" || testDay == "J")
            {
                esIstNacht = true;
            }
            else if (testDay == "n" || testDay == "N")
            {
                esIstNacht= false;
            }




                if (esIstNacht == true)
            {
                if(windStaerke ==0)
                {
                    Console.WriteLine("Er ist Marmeladenbrot");
                }
                else if(windStaerke ==6)
                {
                    Console.WriteLine("Er ist Wirsing");
                }
                else
                {
                    Console.WriteLine("Heute ist er nix");
                }
            }
            else if(esIstNacht == false)
            {
                if( windStaerke ==11)
                {
                    Console.WriteLine("Er ist Sauerkraut");
                }
                else if(windStaerke >= 7 && windStaerke <= 9)
                { 
                Console.WriteLine("Er ist Fischsuppe");
                }
                else if(windStaerke < 4)
                {
                    Console.WriteLine("Er ist Steak");
                }
                else
                {
                    Console.WriteLine("Heute ist er nix");
                }
            }
            
        }
    }
}
