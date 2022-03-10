//Autor : Leon Gießelmann
using System;

namespace Aufgabe_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool schaltjahr = IstSchaltjahr(2004);
            int tage =ErmitleAnzahlTage(5,schaltjahr);
            Console.WriteLine(schaltjahr);
            Console.WriteLine(tage);
        }
        public static bool IstSchaltjahr(int jahr)
        {
            bool isSchaltJahr = false;
            if(jahr % 4 == 0)
            {
                if(jahr % 100 == 0 )
                {
                    isSchaltJahr = false;
                }
                if(jahr % 400 == 0)
                {
                    isSchaltJahr = true;
                }
                
            }
            else
            {
                isSchaltJahr = false;
            }
            
            return isSchaltJahr;
        }
        public static int ErmitleAnzahlTage(int monat,bool schaltjahr)
        {

            if (schaltjahr == true && monat == 2)
            {
                return 29;
            }
            else
            {
                switch (monat)
                {
                    case 1:
                        return 31;
                    case 2:
                        return 28;
                    case 3:
                        return 31;
                    case 4:
                        return 30;
                    case 5:
                        return 31;
                    case 6:
                        return 30;
                    case 7:
                        return 31;
                    case 8:
                        return 31;
                    case 9:
                        return 30;
                    case 10:
                        return 31;
                    case 11:
                        return 30;
                    case 12:
                        return 31;
                }
            }

            return 0;
        }

    }
}
