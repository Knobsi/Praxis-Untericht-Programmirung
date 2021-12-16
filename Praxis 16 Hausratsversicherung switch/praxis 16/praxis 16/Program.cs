using System;

namespace praxis_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int personen;
            int fleche;
            int ergebnis;

            Console.Write("Wieviele petsonen :");
            personen=Convert.ToInt32(Console.ReadLine());

            Console.Write("Wie groß ist die fläche :");
            fleche=Convert.ToInt32(Console.ReadLine());

            
            switch (personen)
            {
                case 1:
                case 2:
                    ergebnis = 10 + fleche * 2;
                    break;
                case 3:
                    ergebnis = 15 + fleche;
                    break;
                case  4:
                    ergebnis = 15 + 3 / 2 * fleche;
                    break;
                default:
                    ergebnis = 25 + 2 * fleche;
                    break;
            }
            Console.WriteLine(fleche);
        }
    }
}
